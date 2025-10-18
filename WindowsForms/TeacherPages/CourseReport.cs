using ApiClients;
using DTOs;
using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.TeacherPages
{
    public partial class CourseReport : Form
    {

        private int _courseId;
        private string _courseTitle;
        public CourseReport(int courseId, string courseTitle)
        {
            InitializeComponent();
            _courseId = courseId;
            _courseTitle = courseTitle;
            InitializeCharts();
            LoadReportData();
        }

        private async void LoadReportData()
        {
            try
            {
                // Obtener datos del curso
                IEnumerable<StudentCourseDetailDTO> students =
                    await StudentCourseApiClient.GetDetailsByCourseIdAsync(_courseId);

                var studentsList = students.ToList();

                // Calcular estadísticas
                int totalInscriptos = studentsList.Count(s => s.Condition == "Inscripto");
                int totalRegulares = studentsList.Count(s => s.Condition == "Regular");
                int totalAprobados = studentsList.Count(s => s.Condition == "Aprobado");
                int totalStudents = studentsList.Count;

                // Calcular promedios por condición
                var inscriptosWithGrade = studentsList.Where(s => s.Condition == "Inscripto" && s.Grade.HasValue);
                var regularesWithGrade = studentsList.Where(s => s.Condition == "Regular" && s.Grade.HasValue);
                var aprobadosWithGrade = studentsList.Where(s => s.Condition == "Aprobado" && s.Grade.HasValue);

                double InscriptosAverage = inscriptosWithGrade.Any() ? inscriptosWithGrade.Average(s => s.Grade.Value) : 0;
                double RegularesAverage = regularesWithGrade.Any() ? regularesWithGrade.Average(s => s.Grade.Value) : 0;
                double AprobadosAverage = aprobadosWithGrade.Any() ? aprobadosWithGrade.Average(s => s.Grade.Value) : 0;

                // Actualizar labels
                courseTitleLabel.Text = _courseTitle;
                totalStudentsLabel.Text = $"Total de Estudiantes: {totalStudents}";
                inscriptosLabel.Text = $"Inscriptos: {totalInscriptos}";
                regularesLabel.Text = $"Regulares: {totalRegulares}";
                aprobadosLabel.Text = $"Aprobados: {totalAprobados}";

                avgRegularesLabel.Text = $"Promedio Regulares: {RegularesAverage:F2}";
                avgAprobadosLabel.Text = $"Promedio Aprobados: {AprobadosAverage:F2}";

                // Crear gráficos
                CreateConditionChart(totalInscriptos, totalRegulares, totalAprobados);
                CreateGradesChart(RegularesAverage, AprobadosAverage);
                CreateGradeDistributionChart(studentsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateConditionChart(int inscriptos, int regulares, int aprobados)
        {
            conditionChart.Series.Clear();
            conditionChart.Titles.Clear();

            conditionChart.Titles.Add("Distribución por Condición");

            Series series = new Series
            {
                Name = "Condiciones",
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("Inscriptos", inscriptos);
            series.Points.AddXY("Regulares", regulares);
            series.Points.AddXY("Aprobados", aprobados);

            // Colores
            series.Points[0].Color = System.Drawing.Color.Orange;
            series.Points[1].Color = System.Drawing.Color.Blue;
            series.Points[2].Color = System.Drawing.Color.Green;

            // Mostrar porcentajes
            series.Label = "#PERCENT{P0}";
            series.LegendText = "#VALX (#VAL)";

            conditionChart.Series.Add(series);
            conditionChart.Legends[0].Enabled = true;
        }

        private void CreateGradesChart(double avgRegulares, double avgAprobados)
        {
            gradesChart.Series.Clear();
            gradesChart.Titles.Clear();
            gradesChart.ChartAreas[0].AxisY.Maximum = 10;
            gradesChart.ChartAreas[0].AxisY.Minimum = 0;

            gradesChart.Titles.Add("Promedio de Notas por Condición");

            Series series = new Series
            {
                Name = "Promedios",
                ChartType = SeriesChartType.Column
            };

            series.Points.AddXY("Regulares", avgRegulares);
            series.Points.AddXY("Aprobados", avgAprobados);

            series.Points[0].Color = System.Drawing.Color.Orange;
            series.Points[1].Color = System.Drawing.Color.Blue;

            series.IsValueShownAsLabel = true;
            series.LabelFormat = "0.00";

            gradesChart.Series.Add(series);
        }

        private void CreateGradeDistributionChart(List<StudentCourseDetailDTO> students)
        {
            gradeDistributionChart.Series.Clear();
            gradeDistributionChart.Titles.Clear();
            gradeDistributionChart.ChartAreas[0].AxisX.Interval = 1;
            gradeDistributionChart.ChartAreas[0].AxisY.Title = "Cantidad de Estudiantes";
            gradeDistributionChart.ChartAreas[0].AxisX.Title = "Nota";

            gradeDistributionChart.Titles.Add("Distribución de Notas");

            Series series = new Series
            {
                Name = "Notas",
                ChartType = SeriesChartType.Column
            };

            // Agrupar por nota (0-10)
            var gradeGroups = students
                .Where(s => s.Grade.HasValue)
                .GroupBy(s => s.Grade.Value)
                .OrderBy(g => g.Key);

            foreach (var group in gradeGroups)
            {
                series.Points.AddXY(group.Key, group.Count());
            }

            series.IsValueShownAsLabel = true;
            series.Color = System.Drawing.Color.SteelBlue;

            gradeDistributionChart.Series.Add(series);
        }

        private void courseReportBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeCharts()
        {
            // Inicializar conditionChart
            if (conditionChart.ChartAreas.Count == 0)
                conditionChart.ChartAreas.Add(new ChartArea());
            if (conditionChart.Legends.Count == 0)
                conditionChart.Legends.Add(new Legend());

            // Inicializar gradesChart
            if (gradesChart.ChartAreas.Count == 0)
                gradesChart.ChartAreas.Add(new ChartArea());
            if (gradesChart.Legends.Count == 0)
                gradesChart.Legends.Add(new Legend());

            // Inicializar gradeDistributionChart
            if (gradeDistributionChart.ChartAreas.Count == 0)
                gradeDistributionChart.ChartAreas.Add(new ChartArea());
            if (gradeDistributionChart.Legends.Count == 0)
                gradeDistributionChart.Legends.Add(new Legend());
        }

    }
}

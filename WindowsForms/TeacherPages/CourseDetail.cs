using ApiClients;
using DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace WindowsForms.TeacherPages
{
    public partial class CourseDetail : Form
    {
        private int courseID;
        private string courseName;
        public CourseDetail(int selectedCourseID, string CourseTitle)
        {
            InitializeComponent();
            courseID = selectedCourseID;
            LoadCourseInfo(courseID);
            this.CourseDetailInfoLabel.Text = CourseTitle;
            courseName = CourseTitle;
        }

        private async void LoadCourseInfo(int id)
        {
            IEnumerable<StudentCourseDetailDTO> courseInfo = await StudentCourseApiClient.GetDetailsByCourseIdAsync(id);
            CourseDetailinfoGrid.DataSource = courseInfo.ToList();

            if (CourseDetailinfoGrid.Columns.Count > 0)
            {
                CourseDetailinfoGrid.Columns["ID"].Visible = false;
                CourseDetailinfoGrid.Columns["IDStudent"].Visible = false;
                CourseDetailinfoGrid.Columns["State"].Visible = false;

                CourseDetailinfoGrid.Columns["StudentName"].HeaderText = "Nombre";
                CourseDetailinfoGrid.Columns["StudentLastName"].HeaderText = "Apellido";
                CourseDetailinfoGrid.Columns["StudentEmail"].HeaderText = "Email";
                CourseDetailinfoGrid.Columns["Grade"].HeaderText = "Nota";
                CourseDetailinfoGrid.Columns["Condition"].HeaderText = "Condición";

                this.SelectStudentButton.Enabled = true;
                this.CourseReportButton.Enabled = true;
            }

        }

        private void SelectStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                StudentCourseDetail studentCourseDetail = new StudentCourseDetail(GetSelectedStudentCourseID());
                studentCourseDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el detalle del alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCourseInfo(courseID);
        }

        private int GetSelectedStudentCourseID()
        {
            if (CourseDetailinfoGrid.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(CourseDetailinfoGrid.SelectedRows[0].Cells["ID"].Value);
            }
            else
            {
                throw new Exception("No se ha seleccionado ningún alumno.");
            }
        }

        private void CourseDetailBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseReportButton_Click(object sender, EventArgs e)
        {
            CourseReport courseReport = new CourseReport(courseID, CourseDetailInfoLabel.Text);
            courseReport.ShowDialog();
        }

        private void exportToPDFButton_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FileName = $"Alumnos {courseName}-{DateTime.Now:dd/MM/yyyy}.pdf"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(saveDialog.FileName);

                    var fileInfo = new FileInfo(saveDialog.FileName);
                    MessageBox.Show($"PDF generado exitosamente\nTamaño: {fileInfo.Length} bytes", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = saveDialog.FileName,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPDF(string filePath)
        {
            try
            {
                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(10));

                        page.Header().Column(column =>
                        {
                            column.Item().Text(courseName ?? "Sin título").FontSize(18).Bold();
                            column.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy}").FontSize(10);
                            column.Item().PaddingBottom(10);
                        });

                        page.Content().Table(table =>
                        {

                            var visibleColumns = CourseDetailinfoGrid.Columns
                                .Cast<DataGridViewColumn>()
                                .Where(c => c.Visible)
                                .OrderBy(c => c.DisplayIndex)
                                .ToList();

                            if (visibleColumns.Count == 0)
                            {
                                throw new Exception("No hay columnas visibles para exportar");
                            }


                            table.ColumnsDefinition(columns =>
                            {
                                foreach (var col in visibleColumns)
                                {
                                    columns.RelativeColumn();
                                }
                            });


                            table.Header(header =>
                            {
                                foreach (var col in visibleColumns)
                                {
                                    header.Cell()
                                        .Background(Colors.Grey.Lighten2)
                                        .Padding(5)
                                        .Text(col.HeaderText ?? "")
                                        .Bold()
                                        .FontSize(10);
                                }
                            });


                            int rowCount = 0;
                            foreach (DataGridViewRow row in CourseDetailinfoGrid.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    foreach (var col in visibleColumns)
                                    {
                                        var cellValue = row.Cells[col.Index].Value?.ToString() ?? "";
                                        table.Cell()
                                            .Border(0.5f)
                                            .BorderColor(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .Text(cellValue)
                                            .FontSize(9);
                                    }
                                    rowCount++;
                                }
                            }

                            if (rowCount == 0)
                            {
                                throw new Exception("No hay filas para exportar");
                            }
                        });

                        page.Footer().AlignCenter().Text(text =>
                        {
                            text.Span("Página ");
                            text.CurrentPageNumber();
                            text.Span(" de ");
                            text.TotalPages();
                        });
                    });
                });

                document.GeneratePdf(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en ExportToPDF: {ex.Message}", ex);
            }
        }
    }
}


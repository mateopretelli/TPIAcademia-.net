using ApiClients;
using DTOs;

namespace ApiClients
{
    public class StudentCourseApiClient : BaseApiClient
    {

        public static async Task AddAsync(int studentId, int courseId)
        {
            try 
            { 
                using var client = await CreateHttpClientAsync();
                StudentCourseDTO studentCourse = new StudentCourseDTO
                {
                    IDstudent = studentId,
                    IDcourse = courseId,
                    Grade = null,
                    Condition = "Inscripto"
                };
                HttpResponseMessage response = await client.PostAsJsonAsync("studentcourses", studentCourse);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();

                    // Intenta extraer el mensaje del JSON
                    try
                    {
                        var errorObj = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(errorContent);
                        throw new Exception(errorObj?.error ?? errorContent);
                    }
                    catch (System.Text.Json.JsonException)
                    {
                        // Si no es JSON válido, usa el contenido completo
                        throw new Exception($"Error: {errorContent}");
                    }
                }

                response.EnsureSuccessStatusCode();
            }
            catch(HttpRequestException ex)
            {
                throw new Exception($"Error al agregar el alumno_curso. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al agregar alumno_curso: {ex.Message}", ex);
            }
        }

        public static async Task<StudentCourseDetailDTO> GetStudentCourseByIdAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync($"/studentCourses/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener alimno_curso por id. Status: {response.StatusCode} - Detalle: {errorContent} ");
                }
                else
                {
                    return await response.Content.ReadAsAsync<StudentCourseDetailDTO>();
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al obtener el alumno_curso por id. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener los el alumno_curso por id. {ex.Message}", ex);
            }

        }

        public static async Task<IEnumerable<StudentCourseDetailDTO>> GetDetailsByCourseIdAsync(int courseId)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync($"/studentCourses/GetStudentsDetail/{courseId}");
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener los detalles de alumno_curso por ID de curso. Status: {response.StatusCode} - Detalle: {errorContent} ");
                }
                return await response.Content.ReadAsAsync<IEnumerable<StudentCourseDetailDTO>>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al obtener los detalles de alumno_curso por ID de curso. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener los detalles de alumno_curso por ID de curso: {ex.Message}", ex);
            }
        }

        public static async void UpdateAsync(StudentCourseDTO dto)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("studentcourses", dto);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar al alumno en el curso. Status: {response.StatusCode} - Detalle: {errorContent} ");
                }

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al actualizar el alumno_curso. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar el alumno_curso: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<StudentCourseDTO>> GetByStudentID(int studentId)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync($"/studentCourses/GetByStudentID/{studentId}");
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener los cursos del alumno por ID de alumno. Status: {response.StatusCode} - Detalle: {errorContent} ");
                }
                return await response.Content.ReadAsAsync<IEnumerable<StudentCourseDTO>>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al obtener los cursos del alumno por ID de alumno. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener los cursos del alumno por ID de alumno: {ex.Message}", ex);
            }
        }
        private class ErrorResponse
        {
            public string error { get; set; }
        }
    }
}

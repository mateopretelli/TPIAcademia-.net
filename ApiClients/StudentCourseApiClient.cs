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

                // ✅ Solo si es exitoso, asegura (opcional en este punto)
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
        private class ErrorResponse
        {
            public string error { get; set; }
        }
    }
}

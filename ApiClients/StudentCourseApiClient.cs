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
                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al agregar el alumno_curso. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
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
    }
}

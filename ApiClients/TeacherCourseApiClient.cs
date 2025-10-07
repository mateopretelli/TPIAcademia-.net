using ApiClients;
using DTOs;

namespace WindowsForms.FormTeacherCourse
{
    internal class TeacherCourseApiClient : BaseApiClient
    {

        public static async Task<TeacherCourseDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("teacherscourses/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<TeacherCourseDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener el docente_docente_curso con id {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al obtener el docente_docente_curso cod id {id}. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener el docente_docente_curso con Id {id}: {ex.Message}", ex);
            }

        }

        public static async Task<IEnumerable<TeacherCourseDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("teacherscourses");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<TeacherCourseDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la lista de docentes_docente_cursos. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener docentes_docente_cursos: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener docentes_docente_cursos: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(TeacherCourseDTO teachercourse)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PostAsJsonAsync("teacherscourses", teachercourse);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al agregar el docente_curso. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al agregar docente_curso: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al agregar docente_curso: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.DeleteAsync("teacherscourses/" + id);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar el docente_curso con ID {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar docente_curso con ID {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar docente_curso con ID {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(TeacherCourseDTO section)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("teacherscourses", section);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar el docente_curso con ID {section.ID}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar docente_curso: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar docente_curso: {ex.Message}", ex);
            }
        }
    }
}

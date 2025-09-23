using DTOs;
using DTOs.Plan;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace WindowsForms.FormSubject

{
    internal class SubjectApiClient
    {
        private static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<SubjectDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("subjects/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<SubjectDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la materia cod id {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error al obtener la materia cod id {id}. Detalle: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener materia con Id {id}: {ex.Message}", ex);
            }

        }

        public static async Task<IEnumerable<SubjectDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("subjects");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<SubjectDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la lista de materias. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener materias: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener materias: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(SubjectDTO subject)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("subjects", subject);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al agregar la materia. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al agregar especialidad: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al agregar especialidad: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("subjects/" + id);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar la materia con ID {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar materia con ID {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar materia con ID {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(SubjectDTO subject)
        {
            try
            { 
                HttpResponseMessage response = await client.PutAsJsonAsync("subjects", subject);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar la materia con ID {subject.ID}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar especialidad: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar especialidad: {ex.Message}", ex);
            }
        }
    }
}

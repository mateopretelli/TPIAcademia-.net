using DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;



namespace WindowsForms.FormSpecialty
{
    internal class SpecialtyApiClient
    {
        private static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<SpecialtyDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("specialties/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<SpecialtyDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la especialidad cod id {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener Especialidad con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener especialidad con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<SpecialtyDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("specialties");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<SpecialtyDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la lista de especialidades. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener especialidades: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener especialidades: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(SpecialtyDTO specialty)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("specialties", specialty);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al agregar la especialidad. Status: {response.StatusCode} - Detalle: {errorContent}");
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
                HttpResponseMessage response = await client.DeleteAsync("specialties/" + id);
                if(!response.IsSuccessStatusCode){
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar la especialidad con ID {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar especialidad con ID {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar especialidad con ID {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(SpecialtyDTO specialty)
        {
            try
            {   


                HttpResponseMessage response = await client.PutAsJsonAsync("specialties", specialty);
                if (!response.IsSuccessStatusCode){
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar la especialidad con ID {specialty.ID}. Status: {response.StatusCode} - Detalle: {errorContent}");
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

        public static async Task<IEnumerable<SpecialtyDTO>> GetByCriteriaAsync(string criteria)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"specialties/criteria?texto={Uri.EscapeDataString(criteria)}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<SpecialtyDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener especialidades por criterio. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener especialidades por criterio: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener especialidades por criterio: {ex.Message}", ex);
            }
        }

    }
}

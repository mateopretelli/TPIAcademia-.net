using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.FormPlans
{
    internal class PlanApiClient
    {
        private static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<PlanDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("plans/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<PlanDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener el plan con id {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener plan con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener plan con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<PlanDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("plans");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PlanDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la lista de planes. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener planes: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener planes: {ex.Message}", ex);
            }
        }
        /*
        public static async Task<List<int>> GetAllSpecialtyIDsAsync()
        {
            IEnumerable<SpecialtyDTO> specialties = null;
            HttpResponseMessage response = await client.GetAsync("specialties");
            if (response.IsSuccessStatusCode)
            {
                specialties = await response.Content.ReadAsAsync<IEnumerable<SpecialtyDTO>>();
            }
            var specialtiesIDs = specialties.Select(p => p.ID).ToList();

            return specialtiesIDs;
        }
        */
        public static async Task<List<int>> GetAllSpecialtyIDsAsync()
        {
            try
            {
                IEnumerable<SpecialtyDTO> specialties = null;
                HttpResponseMessage response = await client.GetAsync("specialties");

                if (response.IsSuccessStatusCode)
                {
                    specialties = await response.Content.ReadAsAsync<IEnumerable<SpecialtyDTO>>();
                    var specialtiesIDs = specialties.Select(p => p.ID).ToList();

                    return specialtiesIDs;
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener la lista de especialidades para un plan. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener especialidades para un plan: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener especialidades para un plan: {ex.Message}", ex);
            }
            
        }
        public async static Task AddAsync(PlanDTO plan)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("plans", plan);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al agregar el plan. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al agregar plan: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al agregar plan: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("plans/" + id);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar el plan con ID {id}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar plan con ID {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar plan con ID {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(PlanDTO plan)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("plans", plan);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar el plan con ID {plan.ID}. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar plan: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar plan: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<PlanDTO>> GetByCriteriaAsync(string criteria)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"plans/criteria?texto={Uri.EscapeDataString(criteria)}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PlanDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener planes por criterio. Status: {response.StatusCode} - Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener planes por criterio: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener planes por criterio: {ex.Message}", ex);
            }
        }
    }
}

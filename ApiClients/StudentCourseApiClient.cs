using ApiClients;
using DTOs;

namespace ApiClients
{
    public class StudentCourseApiClient : BaseApiClient
    {

        public static async Task AddAsync(int studentId, int courseId)
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
        }
    }
}

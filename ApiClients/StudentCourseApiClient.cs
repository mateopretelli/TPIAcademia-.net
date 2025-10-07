using ApiClients;
using DTOs;

namespace WindowsForms.FormStudentCourse
{
    public class StudentCourseApiClient : BaseApiClient
    {
        public static HttpClient client = BaseApiClient.GetClient();

        public static async Task AddAsync(int studentId, int courseId)
        {
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

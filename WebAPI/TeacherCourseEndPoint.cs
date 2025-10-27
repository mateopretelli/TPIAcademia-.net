using Domain.Services;
using DTOs;

namespace Endpoints
{
    public static class TeacherCourseEndPoint
    {
        public static void MapTeacherCourseEndpoints(this WebApplication app)
        {
            app.MapGet("/teacherscourses/{ID}", (int id) =>
            {
                TeacherCourseService teachercourseService = new TeacherCourseService();

                TeacherCourseDTO dto = teachercourseService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
                .WithName("GetTeacherCourse")
                .Produces<TeacherCourseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapGet("/teacherscourses", () =>
            {
                TeacherCourseService teachercourseService = new TeacherCourseService();

                var dtos = teachercourseService.GetAll();

                return Results.Ok(dtos);
            })
                .WithName("GetAllTeachersCourses")
                .Produces<List<TeacherCourseDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapGet("teachercourses/coursesByTeacher/{IDTeacher}", (int idTeacher) =>
            {
                TeacherCourseService teachercourseService = new TeacherCourseService();
                var dtos = teachercourseService.GetCoursesByTeacherId(idTeacher);
                return Results.Ok(dtos);
            })
                .WithName("GetTeachersCoursesByTeacher")
                .Produces<List<TeacherCourseDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapPost("/teacherscourses", (TeacherCourseDTO dto) =>
            {
                try
                {
                    TeacherCourseService teachercourseService = new TeacherCourseService();

                    TeacherCourseDTO teachercourseDTO = teachercourseService.Add(dto);

                    return Results.Created($"/teacherscourses/{teachercourseDTO.ID}", teachercourseDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AddTeacherCourseDTO")
                .Produces<TeacherCourseDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/teacherscourses", (TeacherCourseDTO dto) =>
            {
                try
                {
                    TeacherCourseService teachercourseService = new TeacherCourseService();

                    var found = teachercourseService.Update(dto);

                    if (!found)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("UpdateTeacherCourse")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapDelete("/teacherscourses/{ID}", (int id) =>
            {
                TeacherCourseService teachercourseService = new TeacherCourseService();

                var deleted = teachercourseService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
                .WithName("DeleteTeacherCourse")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/teacherscourses/criteria", (string text) =>
            {
                try
                {
                    TeacherCourseService teachercourseService = new TeacherCourseService();
                    var criteria = new SearchCriteriaDTO { Text = text };
                    var dtos = teachercourseService.GetByCriteria(criteria);
                    return Results.Ok(dtos);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }

            })
                .WithName("GetTeachersCoursesByCriteria")
                .Produces<List<TeacherCourseDTO>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();


        }
    }
}

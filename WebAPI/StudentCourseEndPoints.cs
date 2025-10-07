using Domain.Services;
using DTOs;

namespace Endpoints;

public static class StudentCourseEndPoints
{
    public static void MapStudentCourseEndpoints(this WebApplication app)
    {
        app.MapGet("/studentCourses/{ID}", (int id) =>
        {
            StudentCourseService studentCourseService = new StudentCourseService();

            StudentCourseDTO dto = studentCourseService.Get(id);

            if (dto == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(dto);
        })
        .WithName("GetStudentCourse")
        .Produces<StudentCourseDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/studentCourses", () =>
        {
            StudentCourseService studentCourseService = new StudentCourseService();
            var dtos = studentCourseService.GetAll();
            return Results.Ok(dtos);
        })
        .WithName("GetAllStudentCourses")
        .Produces<List<StudentCourseDTO>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapPost("/studentCourses", (StudentCourseDTO dto) =>
        {
            try
            {
                StudentCourseService studentCourseService = new StudentCourseService();

                StudentCourseDTO studentCourseDTO = studentCourseService.Add(dto);

                return Results.Created($"/studentCourses/{studentCourseDTO.ID}", studentCourseDTO);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
        .WithName("AddStudentCourse")
        .Produces<StudentCourseDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapPut("/studentCourses", (StudentCourseDTO dto) =>
        {
            try
            {
                StudentCourseService studentCourseService = new StudentCourseService();

                var found = studentCourseService.Update(dto);

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
        .WithName("UpdateStudentCourse")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapDelete("/studentCourses/{ID}", (int id) =>
            {
                StudentCourseService studentCourseService = new StudentCourseService();

                var deleted = studentCourseService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteStudentCourse")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

        //Quizas un GetByCriteria
    }
}


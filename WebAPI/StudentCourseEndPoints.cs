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

            StudentCourseDetailDTO dto = studentCourseService.Get(id);

            if (dto == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(dto);
        })
        .WithName("GetStudentCourse")
        .Produces<StudentCourseDetailDTO>(StatusCodes.Status200OK)
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
                try
                {
                    StudentCourseService studentCourseService = new StudentCourseService();

                    var deleted = studentCourseService.Delete(id);

                    if (!deleted)
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
            .WithName("DeleteStudentCourse")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

        app.MapGet("/studentCourses/GetStudentsDetail/{ID}", (int id)=>
        {
            try
            {
                StudentCourseService studentCourseService = new StudentCourseService();
                var dtos = studentCourseService.GetStudentsDetailByCourseId(id);

                if (dtos == null || !dtos.Any())
                {
                    return Results.Ok(new List<StudentCourseDetailDTO>());
                }

                return Results.Ok(dtos);

            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }

        })
            .WithName("GetStudentsDetailByCourseId")
            .Produces<List<StudentCourseDetailDTO>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

        app.MapGet("studentCourses/GetByStudentId/{ID}", (int id) =>
        {
            try
            {
                StudentCourseService studentCourseService = new StudentCourseService();
                var dtos = studentCourseService.GetByStudentId(id);
                if (dtos == null || !dtos.Any())
                {
                    return Results.Ok(new List<StudentCourseDetailDTO>());
                }
                return Results.Ok(dtos);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
            .WithName("GetByStudentId")
            .Produces<List<StudentCourseDTO>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
    }
}


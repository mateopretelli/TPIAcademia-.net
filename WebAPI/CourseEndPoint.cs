using Domain.Services;
using DTOs;

namespace Endpoints
{
    public static class CourseEndPoint
    {
        public static void MapCourseEndpoints(this WebApplication app)
        {
            app.MapGet("/courses/{ID}", (int id) =>
            {
                CourseService courseService = new CourseService();

                CourseDTO dto = courseService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
                .WithName("GetCourse")
                .Produces<CourseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapGet("/courses", () =>
            {
                CourseService courseService = new CourseService();

                var dtos = courseService.GetAll();

                return Results.Ok(dtos);
            })
                .WithName("GetAllCourses")
                .Produces<List<CourseDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapPost("/courses", (CourseDTO dto) =>
            {
                try
                {
                    CourseService courseService = new CourseService();

                    CourseDTO courseDTO = courseService.Add(dto);

                    return Results.Created($"/courses/{courseDTO.ID}", courseDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AddCourseDTO")
                .Produces<CourseDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/courses", (CourseDTO dto) =>
            {
                try
                {
                    CourseService courseService = new CourseService();

                    var found = courseService.Update(dto);

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
                .WithName("UpdateCourse")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapDelete("/courses/{ID}", (int id) =>
            {
                CourseService courseService = new CourseService();

                var deleted = courseService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
                .WithName("DeleteCourse")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/courses/criteria", (string text) =>
            {
                try
                {
                    CourseService courseService = new CourseService();
                    var criteria = new SearchCriteriaDTO { Text = text };
                    var dtos = courseService.GetByCriteria(criteria);
                    return Results.Ok(dtos);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }

            })
                .WithName("GetCoursesByCriteria")
                .Produces<List<CourseDTO>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();


        }
    }
}

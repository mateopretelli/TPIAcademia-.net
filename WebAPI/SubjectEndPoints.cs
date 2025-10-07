using Domain.Services;
using DTOs;

namespace Endpoints
{

    public static class SubjectEndPoints
    {

        public static void MapSubjectEndpoints(this WebApplication app)
        {
            app.MapGet("/subjects/{ID}", (int id) =>
            {
                SubjectService subjectService = new SubjectService();

                SubjectDTO dto = subjectService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetSubject")
            .Produces<SubjectDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/subjects", () =>
            {
                SubjectService subjectService = new SubjectService();

                var dtos = subjectService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllSubjects")
            .Produces<List<SubjectDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();


            app.MapGet("/subjectPlanDescription", () =>
              {
                  PlanService planService = new PlanService();

                  var plans = planService.GetAll();

                  var dtos = plans.Select(plan => new PlanDTO
                  {
                      Description = plan.Description,

                  }).ToList();

                  return Results.Ok(dtos);
              })
              .WithName("GetAllPlansDescripcionForSubject")
              .Produces<List<PlanDTO>>(StatusCodes.Status200OK)
              .WithOpenApi();

            app.MapPost("/subjects", (SubjectDTO dto) =>
            {
                try
                {
                    SubjectService subjectService = new SubjectService();

                    SubjectDTO subjectDTO = subjectService.Add(dto);

                    return Results.Created($"/subjects/{subjectDTO.ID}", subjectDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddSubject")
            .Produces<SubjectDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/subjects", (SubjectDTO dto) =>
            {
                try
                {
                    SubjectService subjectService = new SubjectService();

                    var found = subjectService.Update(dto);

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
            .WithName("UpdateSubject")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/subjects/{ID}", (int id) =>
            {
                SubjectService subjectService = new SubjectService();

                var deleted = subjectService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteSubject")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapGet("/subjects/criteria", (string text) =>
            {
                try
                {
                    SubjectService subjectService = new SubjectService();
                    var criteria = new SearchCriteriaDTO { Text = text };
                    var dtos = subjectService.GetByCriteria(criteria);
                    return Results.Ok(dtos);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }

            })
             .WithName("GetSubjectsByCriteria")
            .Produces<List<SubjectDTO>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}
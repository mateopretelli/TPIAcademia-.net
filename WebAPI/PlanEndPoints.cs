using Domain.Services;
using DTOs;

namespace Endpoints;
public static class PlanEndPoints
{
    public static void MapPlanEndpoints(this WebApplication app)
    {
        app.MapGet("/plans/{ID}", (int id) =>
        {
            PlanService planService = new PlanService();

            PlanDTO dto = planService.Get(id);

            if (dto == null)
            {
                return Results.NotFound();
            }

            return Results.Ok(dto);
        })
        .WithName("GetPlan")
        .Produces<PlanDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/plans", () =>
        {
            PlanService planService = new PlanService();

            var dtos = planService.GetAll();

            return Results.Ok(dtos);
        })
        .WithName("GetAllPlans")
        .Produces<List<PlanDTO>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapGet("/planesEspecialidadesDescripcion", () =>
        {
            SpecialtyService specialtyService = new SpecialtyService();

            var specialties = specialtyService.GetAll();

            var dtos = specialties.Select(specialty => new SpecialtyDTO
            {
                Description = specialty.Description,

            }).ToList();

            return Results.Ok(dtos);
        })
        .WithName("GetAllSpecialtiesDescriptionsForPlans")
        .Produces<List<SpecialtyDTO>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapPost("/plans", (PlanDTO dto) =>
        {
            try
            {
                PlanService planService = new PlanService();

                PlanDTO planDTO = planService.Add(dto);

                return Results.Created($"/plans/{planDTO.ID}", planDTO);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
        .WithName("AddPlan")
        .Produces<PlanDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapPut("/plans", (PlanDTO dto) =>
        {
            try
            {
                PlanService planService = new PlanService();

                var found = planService.Update(dto);

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
        .WithName("UpdatePlan")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapDelete("/plans/{ID}", (int id) =>
        {
            PlanService planService = new PlanService();

            var deleted = planService.Delete(id);

            if (!deleted)
            {
                return Results.NotFound();
            }

            return Results.NoContent();

        })
        .WithName("DeletePlan")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapGet("/plans/criteria", (string texto) =>
        {
            try
            {
                PlanService planService = new PlanService();
                var criteria = new SearchCriteriaDTO { Text = texto };
                var dtos = planService.GetByCriteria(criteria);
                return Results.Ok(dtos);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }

        })
         .WithName("GetPlansByCriteria")
        .Produces<List<PlanDTO>>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();
    
    }
}
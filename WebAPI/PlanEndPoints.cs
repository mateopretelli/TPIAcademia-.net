using Domain.Services;
using Domain.Model;
using DTOs;
using System.Numerics;

namespace Endpoints;

public static class PlanEndPoints
{

    public static void MapPlanEndpoints(this WebApplication app)
    {
        app.MapGet("/planes/{ID}", (int id) =>
        {
            PlanService planService = new PlanService();

            Domain.Model.Plan plan = planService.Get(id);

            if (plan == null)
            {
                return Results.NotFound();
            }

            var dto = new DTOs.Plan
            {
                ID = plan.ID,
                State = plan.State,
                Descripcion = plan.Descripcion,
                IDEspecialidad = plan.IDEspecialidad,
            };

            return Results.Ok(dto);
        })
        .WithName("GetPlan")
        .Produces<DTOs.Plan>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/planes", () =>
        {
            PlanService planService = new PlanService();

            var planes = planService.GetAll();

            var dtos = planes.Select(plan => new DTOs.Plan
            {
                ID = plan.ID,
                State = plan.State,
                Descripcion = plan.Descripcion,
                IDEspecialidad = plan.IDEspecialidad,
            }).ToList();

            return Results.Ok(dtos);
        })
        .WithName("GetAllPlanes")
        .Produces<List<DTOs.Plan>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapPost("/planes", (DTOs.Plan dto) =>
        {
            try
            {
                PlanService planService = new PlanService();

                Domain.Model.Plan plan = new Domain.Model.Plan(dto.Descripcion, dto.IDEspecialidad);

                planService.Add(plan);

                var dtoResultado = new DTOs.Plan
                {
                    ID = plan.ID,
                    State = plan.State,
                    Descripcion = plan.Descripcion,
                    IDEspecialidad = plan.IDEspecialidad,
                };

                return Results.Created($"/planes/{dtoResultado.ID}", dtoResultado);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
        .WithName("AddPlan")
        .Produces<DTOs.Plan>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapPut("/planes", (DTOs.Plan dto) =>
        {
            try
            {
                PlanService planService = new PlanService();

                Domain.Model.Plan plan = new Domain.Model.Plan(dto.Descripcion, dto.IDEspecialidad);
                plan.SetId(dto.ID);
                plan.SetState(dto.State);

                var found = planService.Update(plan);

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

        app.MapDelete("/planes/{ID}", (int id) =>
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
    }
}
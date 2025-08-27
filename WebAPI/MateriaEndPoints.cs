using Domain.Services;
using DTOs.Plan;
using DTOs.Subject;

namespace Endpoints; 

public static class MateriaEndPoints { 

    public static void MapMateriaEndpoints(this WebApplication app) 
    { 
        app.MapGet("/materias/{ID}", (int id) =>
        {
            MateriaService materiaService = new MateriaService();

            Domain.Model.Subject.Materia materia = materiaService.Get(id);

            if (materia == null)
            {
                return Results.NotFound();
            }

            var dto = new DTOs.Subject.Materia
            {
                ID = materia.ID,
                Descripcion = materia.Descripcion,
                HSSemanales = materia.HSSemanales,
                HSTotales = materia.HSTotales,
                IDPlan = materia.IDPlan,
                State = materia.State,
            };

            return Results.Ok(dto);
        })
        .WithName("GetMateria")
        .Produces<Materia>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/materias", () =>
        {
            MateriaService materiaService = new MateriaService();

            var materias = materiaService.GetAll();

            var dtos = materias.Select(materia => new DTOs.Subject.Materia
            {
                ID = materia.ID,
                Descripcion = materia.Descripcion,
                HSSemanales = materia.HSSemanales,
                HSTotales = materia.HSTotales,
                IDPlan = materia.IDPlan,
                State = materia.State,
            }).ToList();

            return Results.Ok(dtos);
        })
        .WithName("GetAllMaterias")
        .Produces<List<Materia>>(StatusCodes.Status200OK)
        .WithOpenApi();


      app.MapGet("/materiasplanesDescripcion", () =>
        {
            PlanService planService = new PlanService();

            var planes = planService.GetAll();

            var dtos = planes.Select(plan => new DTOs.Plan.PlanDTO
            {
                Description = plan.Description,

            }).ToList();

            return Results.Ok(dtos);
        })
        .WithName("GetAllPlanesDescripcionForMateria")
        .Produces<List<PlanDTO>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapPost("/materias", (Materia dto) =>
        {
            try
            {
                MateriaService materiaService = new MateriaService();

                Domain.Model.Subject.Materia materia = new Domain.Model.Subject.Materia(dto.Descripcion, dto.HSSemanales, dto.HSTotales, dto.IDPlan);

                materiaService.Add(materia);

                var dtoResultado = new DTOs.Subject.Materia
                {
                    ID = materia.ID,
                    Descripcion = materia.Descripcion,
                    HSSemanales = materia.HSSemanales,
                    HSTotales = materia.HSTotales,
                    IDPlan = materia.IDPlan,
                    State = materia.State,
                };

                return Results.Created($"/materias/{dtoResultado.ID}", dtoResultado);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
        .WithName("AddMateria")
        .Produces<Materia>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapPut("/materias", (Materia dto) =>
        {
            try
            {
                MateriaService materiaService = new MateriaService();

                Domain.Model.Subject.Materia materia = new Domain.Model.Subject.Materia(dto.Descripcion, dto.HSSemanales, dto.HSTotales, dto.IDPlan);
                materia.SetId(dto.ID);
                materia.SetState(dto.State);

                var found = materiaService.Update(materia);

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
        .WithName("UpdateMateria")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapDelete("/materias/{ID}", (int id) =>
        {
            MateriaService materiaService = new MateriaService();

            var deleted = materiaService.Delete(id);

            if (!deleted)
            {
                return Results.NotFound();
            }

            return Results.NoContent();

        })
        .WithName("DeleteMateria")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();
    }
}
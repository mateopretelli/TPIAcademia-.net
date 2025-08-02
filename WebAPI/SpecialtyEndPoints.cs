using Domain.Services;

namespace Endpoints;
public static class SpecialtyEndPoints
{
    public static void MapSpecialtyEndPoints(this WebApplication app)
    {
        app.MapGet("/specialties/{ID}", (int id) =>
        {
            SpecialtyService specialtyService = new SpecialtyService();

            Domain.Model.Specialty specialty = specialtyService.Get(id);

            if (specialty == null)
            {
                return Results.NotFound();
            }

            var dto = new DTOs.Specialty
            {
                ID = specialty.ID,
                State = specialty.State,
                Descripcion = specialty.Descripcion,
            };

            return Results.Ok(dto);
        })
        .WithName("GetSpecialty")
        .Produces<DTOs.Specialty>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/specialties", () =>
        {
            SpecialtyService specialtyService = new SpecialtyService();

            var specialties = specialtyService.GetAll();

            var dtos = specialties.Select(specialty => new DTOs.Specialty
            {
                ID = specialty.ID,
                State = specialty.State,
                Descripcion = specialty.Descripcion,
            }).ToList();

            return Results.Ok(dtos);
        })
        .WithName("GetAllSpecialties")
        .Produces<List<DTOs.Specialty>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapPost("/specialties", (DTOs.Specialty dto) =>
        {
            try
            {
                SpecialtyService specialtyService = new SpecialtyService();

                Domain.Model.Specialty specialty = new Domain.Model.Specialty(dto.Descripcion);

                specialtyService.Add(specialty);

                var dtoResultado = new DTOs.Specialty
                {
                    ID = specialty.ID,
                    State = specialty.State,
                    Descripcion = specialty.Descripcion,
                };

                return Results.Created($"/specialties/{dtoResultado.ID}", dtoResultado);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
        .WithName("AddSpecialty")
        .Produces<DTOs.Specialty>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapPut("/specialties", (DTOs.Specialty dto) =>
        {
            try
            {
                SpecialtyService specialtyService = new SpecialtyService();

                Domain.Model.Specialty specialty = new Domain.Model.Specialty(dto.Descripcion);
                specialty.SetId(dto.ID);
                specialty.SetState(dto.State);

                var found = specialtyService.Update(specialty);

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
        .WithName("UpdateSpecialty")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapDelete("/specialties/{ID}", (int id) =>
        {
            SpecialtyService specialtyService = new SpecialtyService();

            var deleted = specialtyService.Delete(id);

            if (!deleted)
            {
                return Results.NotFound();
            }

            return Results.NoContent();

        })
        .WithName("DeleteSpecialty")
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();
    }
}

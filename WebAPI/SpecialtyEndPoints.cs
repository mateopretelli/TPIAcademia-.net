using Domain.Services;
using DTOs;

namespace Endpoints;
public static class SpecialtyEndPoints
{
    public static void MapSpecialtyEndPoints(this WebApplication app)
    {
        app.MapGet("/specialties/{ID}", (int id) =>
        {
            SpecialtyService specialtyService = new SpecialtyService();

            SpecialtyDTO dto = specialtyService.Get(id);

            if (dto == null)
            {
                return Results.NotFound();
            }

            return Results.Ok(dto);
        })
        .WithName("GetSpecialty")
        .Produces<DTOs.SpecialtyDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/specialties", () =>
        {
            SpecialtyService specialtyService = new SpecialtyService();

            var dtos = specialtyService.GetAll();

            return Results.Ok(dtos);
        })
        .WithName("GetAllSpecialties")
        .Produces<List<DTOs.SpecialtyDTO>>(StatusCodes.Status200OK)
        .WithOpenApi();

        app.MapPost("/specialties", (SpecialtyDTO dto) =>
        {
            try
            {
                SpecialtyService specialtyService = new SpecialtyService();

                SpecialtyDTO specialtyDTO = specialtyService.Add(dto);

                return Results.Created($"/specialties/{specialtyDTO.ID}", specialtyDTO);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
        .WithName("AddSpecialty")
        .Produces<DTOs.SpecialtyDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

        app.MapPut("/specialties", (SpecialtyDTO dto) =>
        {
            try
            {
                SpecialtyService specialtyService = new SpecialtyService();

                var found = specialtyService.Update(dto);

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

        app.MapGet("/specialties/criteria", (string texto) =>
        {
            try
            {
                SpecialtyService specialtyService = new SpecialtyService();
                var criteria = new SpecialtyCriteriaDTO { Texto = texto };
                var dtos = specialtyService.GetByCriteria(criteria);
                return Results.Ok(dtos);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }

        })
         .WithName("GetSpecialtiesByCriteria")
        .Produces<List<DTOs.SpecialtyDTO>>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status400BadRequest)
        .WithOpenApi();

    }
}

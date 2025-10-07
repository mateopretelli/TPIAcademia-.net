using Domain.Services;
using DTOs;

namespace Endpoints
{
    public static class SectionEndPoints
    {
        public static void MapSectionEndpoints(this WebApplication app)
        {
            app.MapGet("/sections/{ID}", (int id) =>
            {
                SectionService sectionService = new SectionService();

                SectionDTO dto = sectionService.Get(id);

                if (dto == null) 
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
                .WithName("GetSection")
                .Produces<SectionDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapGet("/sections", () =>
            {
                SectionService sectionService = new SectionService();

                var dtos = sectionService.GetAll();

                return Results.Ok(dtos);
            })
                .WithName("GetAllSections")
                .Produces<List<SectionDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapPost("/sections", (SectionDTO dto) =>
            {
                try
                {
                    SectionService sectionService = new SectionService();

                    SectionDTO sectionDTO = sectionService.Add(dto);

                    return Results.Created($"/sections/{sectionDTO.ID}", sectionDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AddSection")
                .Produces<SectionDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/sections", (SectionDTO dto) =>
            {
                try
                {
                    SectionService sectionService = new SectionService();

                    var found = sectionService.Update(dto);

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
                .WithName("UpdateSection")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapDelete("/sections/{ID}", (int id) =>
            {
                SectionService sectionService = new SectionService();

                var deleted = sectionService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
                .WithName("DeleteSection")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/sections/criteria", (string text) =>
            {
                try
                {
                    SectionService sectionService = new SectionService();
                    var criteria = new SearchCriteriaDTO { Text = text };
                    var dtos = sectionService.GetByCriteria(criteria);
                    return Results.Ok(dtos);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }

            })
                .WithName("GetSectionsByCriteria")
                .Produces<List<SectionDTO>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();


        }
    }
}

using Domain.Services;
using DTOs;

namespace Endpoints;

public static class UserEndPoints
{
    public static void MapUserEndPoints(this WebApplication app)
    {
        app.MapGet("/users/{ID}", (int id) =>
        {
            UserService userService = new UserService();
            UserDTO dto = userService.Get(id);

            if (dto == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(dto);
        })
        .WithName("GetUser")
        .Produces<UserDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/users", () =>
        {
            UserService userService = new UserService();


            var dtos = userService.GetAll();

            return Results.Ok(dtos);
        })
          .WithName("GetAllUsers")
          .Produces<List<UserDTO>>(StatusCodes.Status200OK)
          .Produces(StatusCodes.Status404NotFound)
          .WithOpenApi();

        app.MapGet("/userPlanesDescripcion", () =>
        {
            PlanService planService = new PlanService();

            var planes = planService.GetAll();

            var dtos = planes.Select(plan => new PlanDTO
            {
                Description = plan.Description,

            }).ToList();

            return Results.Ok(dtos);
        })
        .WithName("GetAllPlanesDescripcionForUsers")
        .Produces<List<PlanDTO>>(StatusCodes.Status200OK)
        .WithOpenApi();
        //ver aca!!!
        app.MapPost("/users", (UserDTO dto) =>
        {
            try
            {
                UserService userService = new UserService();

                UserDTO userDTO = userService.Add(dto);

                return Results.Created($"/users/{userDTO.ID}", userDTO);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
          .WithName("AddUser")
          .Produces<UserDTO>(StatusCodes.Status201Created)
          .Produces(StatusCodes.Status400BadRequest)
          .WithOpenApi();

        app.MapPut("/users", (UserDTO dto) =>
        {
            try
            {
                UserService userService = new UserService();

                var found= userService.Update(dto);

                if (!found)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
          .WithName("UpdateUser")
          .Produces(StatusCodes.Status204NoContent)
          .Produces(StatusCodes.Status404NotFound)
          .Produces(StatusCodes.Status400BadRequest)
          .WithOpenApi();

        app.MapDelete("/users/{id}", (int id) =>
        {
            UserService userService = new UserService();

            var deleted = userService.Delete(id);

            if (!deleted)
            {
                return Results.NotFound();
            }

            return Results.NoContent();
        })
          .WithName("DeleteUser")
          .Produces(StatusCodes.Status204NoContent)
          .Produces(StatusCodes.Status404NotFound)
          .WithOpenApi();

        app.MapGet("/users/criteria", (string texto) =>
        {
            try
            {
                UserService userService = new UserService();
                var criteria = new UserCriteriaDTO { Texto = texto };
                var dtos = userService.GetByCriteria(criteria);
                return Results.Ok(dtos);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }

        })
          .WithName("GetUsersByCriteria")
          .Produces<List<SpecialtyDTO>>(StatusCodes.Status200OK)
          .Produces(StatusCodes.Status400BadRequest)
          .WithOpenApi();
    }

}

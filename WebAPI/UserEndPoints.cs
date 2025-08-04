using Domain.Services;
using Domain.Model;
using DTOs;

namespace Endpoints;

public static class UserEndPoints
{
    public static void MapUserEndPoints(this WebApplication app)
    {
        app.MapGet("/users/{ID}", (int id) =>
        {
            UserService userService = new UserService();
            Domain.Model.User user = userService.Get(id);

            if (user == null)
            {
                return Results.NotFound();
            }
            var dto = new DTOs.User
            {
                ID = user.ID,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.email,
                Address = user.Address,
                Phone = user.Phone,
                Legajo = user.Legajo,
                BirthDate = user.birthDate,
                IDPlan = user.IDPlan,
                Username = user.Username,
                Password = user.Password,
                State = user.State
            };
            return Results.Ok(dto);
        })
        .WithName("GetUser")
        .Produces<DTOs.User>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithOpenApi();

        app.MapGet("/users", () =>
        {
            UserService userService = new UserService();
            var users = userService.GetAll();
            var dtos = users.Select(user => new DTOs.User
            {
                ID = user.ID,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.email,
                Address = user.Address,
                Phone = user.Phone,
                Legajo = user.Legajo,
                BirthDate = user.birthDate,
                IDPlan = user.IDPlan,
                Username = user.Username,
                Password = user.Password,
                State = user.State
            }).ToList();
            return Results.Ok(dtos);
        })
          .WithName("GetAllUsers")
          .Produces<List<DTOs.User>>(StatusCodes.Status200OK)
          .Produces(StatusCodes.Status404NotFound)
          .WithOpenApi();

        app.MapPost("/users", (DTOs.User userDto) =>
        {
            try
            {
                UserService userService = new UserService();
                Domain.Model.User user = new Domain.Model.User(userDto.Name, userDto.LastName, userDto.Email, userDto.Address, userDto.Phone, userDto.Legajo, userDto.BirthDate, userDto.IDPlan, userDto.Username, userDto.Password);

                userService.Add(user);

                var dtoresultado = new DTOs.User
                {
                    Name = userDto.Name,
                    LastName = userDto.LastName,
                    Email = userDto.Email,
                    Address = userDto.Address,
                    Phone = userDto.Phone,
                    Legajo = userDto.Legajo,
                    BirthDate = userDto.BirthDate,
                    IDPlan = userDto.IDPlan,
                    Username = userDto.Username,
                    Password = userDto.Password
                };

                return Results.Created($"/users/{user.ID}", userDto);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
          .WithName("AddUser")
          .Accepts<DTOs.User>("application/json")
          .Produces<DTOs.User>(StatusCodes.Status201Created)
          .Produces(StatusCodes.Status400BadRequest)
          .WithOpenApi();

        app.MapPut("/users", (DTOs.User userDto) =>
        {
            try
            {
                UserService userService = new UserService();
                Domain.Model.User user = new Domain.Model.User(userDto.Name, userDto.LastName, userDto.Email, userDto.Address, userDto.Phone, userDto.Legajo, userDto.BirthDate, userDto.IDPlan, userDto.Username, userDto.Password)
                {
                    ID = userDto.ID,
                    State = userDto.State
                };
                if (userService.Update(user))
                {
                    return Results.Ok(userDto);
                }
                else
                {
                    return Results.NotFound();
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        })
          .WithName("UpdateUser")
          .Accepts<DTOs.User>("application/json")
          .Produces<DTOs.User>(StatusCodes.Status200OK)
          .Produces(StatusCodes.Status404NotFound)
          .WithOpenApi();

        app.MapDelete("/users/{id}", (int id) =>
        {
            UserService userService = new UserService();
            if (userService.Delete(id))
            {
                return Results.NoContent();
            }
            else
            {
                return Results.NotFound();
            }
        })
          .WithName("DeleteUser")
          .Produces(StatusCodes.Status204NoContent)
          .Produces(StatusCodes.Status404NotFound)
          .WithOpenApi();
    }

}

using Domain.Model;
using Domain.Services;
using DTOs;

namespace WebAPI
{
    public static class PeopleEndPoints
    {

        public static void MapPeopleEndpoints(this WebApplication app)
        {
            app.MapGet("/people/{ID}", (int id) =>
            {
                var personService = new Domain.Services.PeopleService();
                var person = personService.Get(id);
                if (person == null)
                {
                    return Results.NotFound();
                }
                var dto = new DTOs.Person
                {
                    ID = person.ID,
                    State = person.State,
                    Name = person.Name,
                    Surname = person.Surname,
                    Email = person.Email,
                    BirthDate = person.BirthDate,
                    PhoneNumber = person.PhoneNumber,
                    PersonalID = person.PersonalID,
                    Address = person.Address,
                    IDPlan = person.IDPlan,
                    PersonType = (int)person.PersonType
                };
                return Results.Ok(dto);
            })
            .WithName("GetPerson")
            .Produces<DTOs.Person>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
            app.MapGet("/people", () =>
            {
                var personService = new Domain.Services.PeopleService();
                var people = personService.GetAll();
                var dtos = people.Select(person => new DTOs.Person
                {
                    ID = person.ID,
                    State = person.State,
                    Name = person.Name,
                    Surname = person.Surname,
                    Email = person.Email,
                    BirthDate = person.BirthDate,
                    PhoneNumber = person.PhoneNumber,
                    PersonalID = person.PersonalID,
                    Address = person.Address,
                    IDPlan = person.IDPlan,
                    PersonType = (int)person.PersonType
                }).ToList();
                return Results.Ok(dtos);
            })
            .WithName("GetAllPeople")
            .Produces<List<DTOs.Person>>(StatusCodes.Status200OK)
            .WithOpenApi();
        }

    }
}

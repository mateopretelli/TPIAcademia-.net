using Data;
using Domain.Model;
using DTOs;
using Data.Security;

namespace Domain.Services
{
    public class UserService
    {
        public UserDTO Add(UserDTO dto)
        {
            var userRepository = new UserRepository();
            var passwordHasher = new PasswordHasherPBKDF2();

            if (userRepository.UserExists(dto.Email))
            {
                throw new ArgumentException("Ya existe un usuario con ese email.", nameof(dto.Email));
            }

            var (hash, salt) = passwordHasher.HashPassword(dto.Password);

            User user = new User(
                dto.Name, 
                dto.LastName, 
                dto.Email, 
                dto.Address, 
                dto.Phone, 
                dto.Legajo, 
                dto.BirthDate, 
                dto.Type, 
                dto.IDPlan, 
                dto.Username, 
                hash,
                salt);

            user.SetState("Active");
            user.SetLegajo();

            userRepository.Add(user);

            dto.ID = user.ID;
            dto.State = user.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var userRepository = new UserRepository();
            return userRepository.Delete(id);
        }

        public UserDTO Get(int id)
        {
            var userRepository = new UserRepository();

            User? user = userRepository.Get(id);

            if (user == null)
            {
                return null;
            }

            return new UserDTO
            {
                ID = user.ID,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                Phone = user.Phone,
                Legajo = user.Legajo,
                BirthDate = user.BirthDate,
                IDPlan = user.IDPlan,
                Username = user.Username,
                Password = user.Password,
                State = user.State
            };
        }

        public UserDTO GetByLegajo(int legajo) 
        {
            var userRepository = new UserRepository();
            User? user = userRepository.GetByLegajo(legajo);
            if (user == null)
            {
                return null;
            }
            return new UserDTO
            {
                ID = user.ID,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                Phone = user.Phone,
                Legajo = user.Legajo,
                BirthDate = user.BirthDate,
                Type = user.Type,
                IDPlan = user.IDPlan,
                Username = user.Username,
                Password = user.Password,
                State = user.State
            };
        }

        public UserDTO GetByUsername(string username)
        {
            var userRepository = new UserRepository();
            User? user = userRepository.GetByUsername(username);
            if (user == null)
            {
                return null;
            }
            return new UserDTO
            {
                ID = user.ID,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                Phone = user.Phone,
                Legajo = user.Legajo,
                BirthDate = user.BirthDate,
                IDPlan = user.IDPlan,
                Username = user.Username,
                Password = user.Password,
                State = user.State,
                Salt = user.Salt,
            };
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var userRepository = new UserRepository();
            return userRepository.GetAll()
                .Select(u => new UserDTO
                {
                    ID = u.ID,
                    Name = u.Name,
                    LastName = u.LastName,
                    Email = u.Email,
                    Address = u.Address,
                    Phone = u.Phone,
                    Legajo = u.Legajo,
                    BirthDate = u.BirthDate,
                    Type = u.Type,
                    IDPlan = u.IDPlan,
                    Username = u.Username,
                    Password = u.Password,
                    State = u.State
                }).ToList();
        }

        public IEnumerable<UserDTO> GetAllPerType(int typeNumber)
        {
            var userRepository = new UserRepository();
            return userRepository.GetAll()
                .Where(u => u.Type == typeNumber)
                .Select(u => new UserDTO
                {
                    ID = u.ID,
                    Name = u.Name,
                    LastName = u.LastName,
                    Email = u.Email,
                    Address = u.Address,
                    Phone = u.Phone,
                    Legajo = u.Legajo,
                    BirthDate = u.BirthDate,
                    IDPlan = u.IDPlan,
                    Username = u.Username,
                    Password = u.Password,
                    State = u.State,
                    Type = u.Type
                }).ToList();
        }

        public bool Update(UserDTO dto)
        {
            var userRepository = new UserRepository();

            if (userRepository.UserExists(dto.Email, dto.ID))
            {
                throw new ArgumentException("Ya existe un usuario con ese email.", nameof(dto.Email));
            }

            User user = new User(dto.Name, dto.LastName, dto.Email, dto.Address, dto.Phone, dto.Legajo, dto.BirthDate, dto.Type, dto.IDPlan, dto.Username, dto.Password, dto.Salt)
            {
                ID = dto.ID,
                State = dto.State,
            };
            return userRepository.Update(user);
        }

        public IEnumerable<UserDTO> GetByCriteria(SearchCriteriaDTO criteriaDTO)
        {
            var userRepository = new UserRepository();

            //Mapea DTO a Domain Model
            var criteria = new SearchCriteria(criteriaDTO.Text);

            //Llama al repositorio para obtener los usuarios
            var users = userRepository.GetByCriteria(criteria);

            //Mapea Domain Model a DTO
            return users.Select(u => new UserDTO
            {
                ID = u.ID,
                Name = u.Name,
                LastName = u.LastName,
                Email = u.Email,
                Address = u.Address,
                Phone = u.Phone,
                Legajo = u.Legajo,
                BirthDate = u.BirthDate,
                Type = u.Type,
                IDPlan = u.IDPlan,
                Username = u.Username,
                Password = u.Password,
                State = u.State
            });
        }

        public bool Login(string username, string password)
        {
            var userRepository = new UserRepository();
            var user = userRepository.GetByUsername(username);
            if (user == null)
            {
                return false;
            }
            var passwordHasher = new PasswordHasherPBKDF2();
            return passwordHasher.VerifyPassword(password, user.Password, user.Salt);
        }
    }
}
 
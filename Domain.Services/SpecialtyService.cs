using Data;
using Domain.Model;

namespace Domain.Services
{
    public class SpecialtyService
    {
        public void Add(Specialty specialty)
        {
            specialty.SetId(GetNextId());
            specialty.SetState("Active");
            SpecialtyInMemory.Specialties.Add(specialty);
        }

        public bool Delete(int id)
        {
            Specialty? specialtyToDelete = SpecialtyInMemory.Specialties.Find(x => x.ID == id);

            if (specialtyToDelete != null)
            {
                SpecialtyInMemory.Specialties.Remove(specialtyToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public Specialty Get(int id)
        {
            return SpecialtyInMemory.Specialties.Find(x => x.ID == id);
        }

        public IEnumerable<Specialty> GetAll()
        {
            //Devuelvo una lista nueva cada vez que se llama a GetAll
            //pero idealmente deberia implementar un Deep Clone
            return SpecialtyInMemory.Specialties.ToList();
        }

        public bool Update(Specialty specialty)
        {
            Specialty? specialtyToUpdate = SpecialtyInMemory.Specialties.Find(x => x.ID == specialty.ID);

            if (specialtyToUpdate != null)
            {
                specialtyToUpdate.SetDescripcion(specialty.Descripcion);
                specialtyToUpdate.SetState(specialty.State);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextId()
        {
            int nextId;

            if (SpecialtyInMemory.Specialties.Count > 0)
            {
                nextId = SpecialtyInMemory.Specialties.Max(x => x.ID) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}

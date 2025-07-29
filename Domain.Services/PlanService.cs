using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Model;

namespace Domain.Services
{
    public class PlanService
    {
        public void Add(Plan plan)
        {
            plan.SetId(GetNextId());
            plan.SetState("Active");
            PlanInMemory.Planes.Add(plan);
        }

        public bool Delete(int id)
        {
            Plan? planToDelete = PlanInMemory.Planes.Find(x => x.ID == id);

            if (planToDelete != null)
            {
                PlanInMemory.Planes.Remove(planToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public Plan Get(int id)
        {
            return PlanInMemory.Planes.Find(x => x.ID == id);
        }

        public IEnumerable<Plan> GetAll()
        {
            //Devuelvo una lista nueva cada vez que se llama a GetAll
            //pero idealmente deberia implementar un Deep Clone
            return PlanInMemory.Planes.ToList();
        }

        public bool Update(Plan plan)
        {
            Plan? planToUpdate = PlanInMemory.Planes.Find(x => x.ID == plan.ID);

            if (planToUpdate != null)
            {
                planToUpdate.SetDescripcion(plan.Descripcion);
                planToUpdate.SetIDEspecialidad(plan.IDEspecialidad);
                planToUpdate.SetState(plan.State);

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

            if (PlanInMemory.Planes.Count > 0)
            {
                nextId = PlanInMemory.Planes.Max(x => x.ID) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}

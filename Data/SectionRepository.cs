using Domain.Model;
using Domain.Model.Plan;
using Domain.Model.Section;
using Domain.Model.Subject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SectionRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Section section)
        {
            using var context = CreateContext();
            context.Sections.Add(section);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var section = context.Sections.Find(id);
            if (section != null)
            {
                context.Sections.Remove(section);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Section? Get(int id)
        {
            using var context = CreateContext();
            return context.Sections
                .Include(c => c.Plan)
                .FirstOrDefault(c => c.ID == id);
        }

        public IEnumerable<Section> GetAll()
        {
            using var context = CreateContext();
            return context.Sections
                .Include(c => c.Plan)
                    .ThenInclude(p => p.Specialty)
                .ToList();
        }

        public bool Update(Section section)
        {
            using var context = CreateContext();
            var existingSection = context.Sections.Find(section.ID);
            if (existingSection != null)
            {
                existingSection.SetDescription(section.Description);
                existingSection.SetIDPlan(section.IDPlan);
                existingSection.SetSpecialtyYear(section.SpecialtyYear);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SectionExists(string description, int idPlan, int specialtyYear, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Sections.Where(c => c.Description.ToLower() == description.ToLower() && c.IDPlan == idPlan && c.SpecialtyYear == specialtyYear);
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<Section> GetByCriteria(SearchCriteria criteria)
        {
            using var context = CreateContext();
            return context.Sections.Where(s => s.Description.ToLower() == criteria.Text);
        }


    }
}

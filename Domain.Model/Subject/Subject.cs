using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model.Subject
{
    public class Subject : BusinessEntity
    {
        public string Description { get; private set; }
        public int WeeklyHS { get; private set; }
        public int TotalHS { get; private set; }
        public int IDPlan { get; private set; }

        public Subject(string description, int weeklyHS, int totalHS, int iDPlan)
        {
            Description = description;
            WeeklyHS = weeklyHS;
            TotalHS = totalHS;
            IDPlan = iDPlan;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(description));
            Description = description;
        }

        public void SetWeeklyHS(int weeklyHS)
        {
            if (weeklyHS < 0)
                throw new ArgumentException("Las horas semanales deben ser mayores o iguales a 0.", nameof(weeklyHS));
            WeeklyHS = weeklyHS;
        }

        public void SetTotalHS(int totalHS)
        {
            if (totalHS < 0)
                throw new ArgumentException("Las horas totales deben ser mayores o iguales a 0.", nameof(totalHS));
            TotalHS = totalHS;
        }

        public void SetIDPlan(int idPlan)
        {
            if (idPlan < 0)
                throw new ArgumentException("El ID del plan debe ser mayor que 0.", nameof(idPlan));
            IDPlan = idPlan;

        }
    }
}
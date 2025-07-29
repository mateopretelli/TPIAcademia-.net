using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Materia : BusinessEntity
    {
        public string Descripcion { get; private set; }
        public int HSSemanales { get; private set; }
        public int HSTotales { get; private set; }
        public int IDPlan { get; private set; }

        public Materia(string descripcion, int hSSemanales, int hSTotales, int iDPlan)
        {
            Descripcion = descripcion;
            HSSemanales = hSSemanales;
            HSTotales = hSTotales;
            IDPlan = iDPlan;
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            ID = id;
        }

        public void SetState(string state)
        {
            State = state;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetHSSemanales(int hSSemanales)
        {
            if (hSSemanales < 0)
                throw new ArgumentException("Las horas semanales deben ser mayores o iguales a 0.", nameof(hSSemanales));
            HSSemanales = hSSemanales;
        }

        public void SetHSTotales(int hSTotales)
        {
            if (hSTotales < 0)
                throw new ArgumentException("Las horas totales deben ser mayores o iguales a 0.", nameof(hSTotales));
            HSTotales = hSTotales;
        }

        public void SetIDPlan(int idPlan)
        {
            if (idPlan < 0)
                throw new ArgumentException("El ID del plan debe ser mayor que 0.", nameof(idPlan));
            IDPlan = idPlan;

        }
    }
}
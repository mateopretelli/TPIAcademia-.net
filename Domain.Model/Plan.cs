using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Plan : BusinessEntity
    {
        public string Descripcion { get; private set; }
        public int IDEspecialidad { get; private set; }

        public Plan(string descripcion, int idEsp) 
        {
            Descripcion = descripcion;
            IDEspecialidad = idEsp;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetIDEspecialidad(int idEsp)
        {
            if (idEsp < 0)
                throw new ArgumentException("El ID de la especialidad debe ser mayor que 0.", nameof(idEsp));
            IDEspecialidad = idEsp;
        }
    }
}
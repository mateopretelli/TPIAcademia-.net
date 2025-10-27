using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class BusinessEntity
    {
        public int ID { get; set; }
        public string State { get; set; }

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

    }
}
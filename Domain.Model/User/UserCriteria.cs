using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.User
{
    public class UserCriteria
    {
        public string Texto { get; private set; }

        public UserCriteria(string texto)
        {
            Texto = texto.Trim();
        }
    }
}

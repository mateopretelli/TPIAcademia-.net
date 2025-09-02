using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Subject
{
    public class SubjectCriteria
    {
        public string Text { get; private set; }

        public SubjectCriteria(string text)
        {
            Text = text.Trim();
        }
    }
}

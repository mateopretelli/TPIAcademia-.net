using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class SearchCriteria
    {
        public string Text { get; private set; }

        public SearchCriteria(string text)
        {
            Text = text.Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class PlanInMemory
    {
        public static List<Plan> Planes;

        static PlanInMemory()
        {
            Planes = new List<Plan>();

            Plan plan = new Plan("2025", 103);
            plan.SetId(1);
            plan.SetState("Active");
            Planes.Add(plan);

            plan = new Plan("2008", 102);
            plan.SetId(2);
            plan.SetState("Active");
            Planes.Add(plan);

            plan = new Plan("1998", 101);
            plan.SetId(3);
            plan.SetState("Active");
            Planes.Add(plan);
        }
    }
}

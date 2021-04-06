using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSite.Models
{
    public class Tree: Plant
    {
        public Tree()
        {
            this.Name = "Tree";
            this.Size = 4.5;           
        }

        public override void Grow()
        {
            this.Size += 3.2;
        }
    }
}

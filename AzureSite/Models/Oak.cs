using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSite.Models
{
    public class Oak : Tree
    {
        public Oak()
        {
            this.Name = "Oak";
            this.Size = 6;
        }

        public override void Grow()
        {
            this.Size += 6.5;
        }
    }
}

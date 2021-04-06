using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSite.Models
{
    public class Flower : Plant
    {
        public Flower()
        {
            this.Name = "Flower";
            this.Size = .5;
        }

        public override void Grow()
        {
            this.Size += .2;
        }
    }
}

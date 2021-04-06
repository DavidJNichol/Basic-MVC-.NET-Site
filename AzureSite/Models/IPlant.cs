using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSite.Models
{
    public interface IPlant
    {
        public void Grow();

        public double GetSize();

        public string GetName();

        public void Water();

        public string Name { get; set; }

        public double Size { get; set; }

        public bool isWatered { get; set; }

        public string canGrowString { get; set; }

        public string About();
    }
}

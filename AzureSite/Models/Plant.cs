using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSite.Models
{
    public abstract class Plant : PageModel, IPlant
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public double Size { get; set; }
        [BindProperty]
        public bool isWatered { get; set; }
        public string canGrowString { get; set; }

        public Plant()
        {
            this.Name = "Default Name";
            this.Size = 0;
            this.isWatered = false;
            this.canGrowString = " cannot grow because it hasn't been watered.";
        }

        public string About()
        {
            if(isWatered)
            {
                canGrowString = " can grow.";
            }

            //ViewData["confirmation"] = this.Name + " is " + this.Size + " feet tall and " + canGrowString; 

            return this.Name + " is " + this.Size + " feet tall and " + canGrowString;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetSize()
        {
            return this.Size;
        }

        public virtual void Grow()
        {
            this.Size++;
        }

        public void Water()
        {
            this.isWatered = true;
        }
    }
}

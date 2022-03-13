using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignement2_BRICE_DENIS
{
    internal class Doctor
    {
        private int Id;
        private string Name;
        private int Tel;
        private DateTime HiringDate;
        private string Specialism;

        public Doctor(int id, string name,int tel,DateTime hiring, string spcialism)
        {
            this.Id = id;
            this.Name = name;
            this.Tel = tel;
            this.HiringDate = hiring;
            this.Specialism = spcialism;
        } 
    }
}

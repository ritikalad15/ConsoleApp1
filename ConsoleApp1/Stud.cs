using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stud
    {
        private int studid;
        private string studname;


        public Stud(int studid,string studname)
        {
            this.studid = studid;
            this.studname = studname;
        }

        public override string ToString()
        {
            return $"{studid}  {studname}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class RandomNumb
    {
        Random r = new Random();
        

        public int RNDNumber { get; set; }


        public void GetRNDNumber()

        {
            RNDNumber = r.Next(1, 7);
                       
        }










    }
}

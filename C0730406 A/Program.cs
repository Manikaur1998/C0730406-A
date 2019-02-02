using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730406_A
{
    class Program
    {
        static void Main(string[] args)
        {
            countryside c = new countryside();
        }

            class village
        {
            bool isAstrildeHere;
           public  village nextvillage;
             public village prevvillage;
           public String villagename;


        }

        class countryside
        {
            village Toronto;
            village maple;
            village ajax;

            public void rise()
            {
                maple = new village();
                maple.villagename =" Toronto";
                maple.nextvillage = Toronto;
            }
        }

    }
}


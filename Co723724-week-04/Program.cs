using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co723724_week_04
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                countryside blue = new countryside();
                blue.launch();
            }
        }
        class Village
        {
            //Node is an ADT
            // what KIND of DATA do we Need in a Node?
            public Village nextVillage;
            public Village previousVillage;
            public string Villagename;
            public bool isAstrildeHere = false;

        }
        class countryside
        {
            Village Maple = new Village();
            Village Toronto = new Village();
            Village Ajax = new Village();
            Village First;
            Village Last;
            Village Temp;


            public void launch()
            {

                First = Maple;
                Last = Ajax;
                Maple.Villagename = "Maple";
                Maple.nextVillage = Toronto;
                Maple.previousVillage = null;
                Toronto.Villagename = "Toronto:";
                Toronto.nextVillage = Maple;
                Toronto.previousVillage = Maple;
                Ajax.Villagename = " Ajax";
                Ajax.nextVillage = null;
                Ajax.previousVillage = Toronto;

                Console.WriteLine(this.displayMap());




            }
            public string displayMap()
            {
                string listOfCities = "";
                // what problem do i need to solve?

                listOfCities = listOfCities + First.Villagename + "-----";
                Temp = First.nextVillage;
                listOfCities = listOfCities + Temp.Villagename + "-------";


                return listOfCities;
            }
        }
    }

}


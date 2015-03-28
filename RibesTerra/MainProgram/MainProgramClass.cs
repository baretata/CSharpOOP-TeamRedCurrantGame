namespace MainProgram
{
    using System;
    using System.Collections.Generic;


    using Models;
    using Models.Gear.Interfaces;
    using Models.Gear.Items;   //loading GameModels library functionalities

    public class MainProgramClass
    {
        public static void Main()
        {
            // a stupid test 
            List<IGear> items = new List<IGear>();
            items.Add(new Armour("aaa", 12, "aaaArmor",2, 150));
            items.Add(new Gloves("xxx", 1522, "xxxGloves",3, 150, 45));
            items.Add(new Boots("yyy", 102, "yyyBoots",4, 150, 15));
            items.Add(new Armour("zzz", 14, "zzzArmor",5, 150));



        }
    }
}

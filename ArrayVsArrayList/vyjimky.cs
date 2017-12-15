using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsArrayList
{
    class vyjimky
    {

        string vstup = "3acj";

        
        try
        {
        int cislo = int.Parse(vstup);
        }
// tu vyhodi ako vynimku vyhodi, na ktorej padne

        catch (Exception exception)
        {
        Console.WriteLine(Exception.Message);
        }

        Console.Readline();
    }
}

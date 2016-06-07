using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IDictionary
    {
        //true = gefunden
        bool Search(int elem);
        //true = hinzugefügt
        bool Insert(int elem);
        //true = gelöscht
        bool Delete(int elem);
        //Einfache Ausgabe
        void Print();
    }
}

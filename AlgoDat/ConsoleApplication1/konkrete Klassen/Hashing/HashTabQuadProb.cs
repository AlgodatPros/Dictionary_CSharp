using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.konkrete_Klassen;

namespace ConsoleApplication1
{
    class HashTabQuadProb: Hashing
    {
        int key = 0;


         override public bool Insert(int elem)
        {
            key = hash(elem);

            for (int i = 1; i < ArrayHashTable.Length - 1; i++)
            {
                if (ArrayHashTable[key] != null)
                {
                    key = (key + i) % 10;
                }
                else
                {
                    ArrayHashTable[key] = elem;
                    return true;
                }
            }
            return false;
        }

         public override bool Search(int elem)
         {
             throw new NotImplementedException();
         }

         public override bool Delete(int elem)
         {
             throw new NotImplementedException();
         }

         public override void Print()
         {
             for (int i = 0; i < ArrayHashTable.Length; i++)
             {
                 Console.Write("Reihe " + i + ": " + ArrayHashTable[i]);
                 Console.WriteLine();
                 
             }
             Console.WriteLine("=========");
         }

    }
}
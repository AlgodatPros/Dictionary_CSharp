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

             if (_Search(elem) > 0)
             {
                 return true;
             }
             else
                 return false;
         }

         public int _Search(int elem)
         {
             key = hash(elem);
             int index = 0;
             for (int i = 0; i < ArrayHashTable.Length; i++)
             {
                 index = (key + i) % ArrayHashTable.Length;
                 if (ArrayHashTable[index] == key)
                 {
                     return index;
                 }
             }
             return -1;
         }

         public override bool Delete(int elem)
         {
             int index = _Search(elem);
             if (Search(elem))
             {
                 ArrayHashTable[index] = null;
                 return true;
             }
             else
                 return false;
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
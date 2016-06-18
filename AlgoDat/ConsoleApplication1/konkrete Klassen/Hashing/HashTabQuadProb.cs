using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryFramework.konkrete_Klassen;

namespace DictionaryFramework.konkrete_Klassen
{
    class HashTabQuadProb: Hashing, IMultisetUnsorted
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
			return false;
            // throw new NotImplementedException();
         }

         public override bool Delete(int elem)
         {
			return false;
             //throw new NotImplementedException();
         }

         public override void Print()
         {
             for (int i = 0; i < ArrayHashTable.Length; i++)
             {
				int? elem = ArrayHashTable[i];
				if (elem != null) {
					Console.Write (elem);
					Console.Write (" ");
				}
                 
             }
             Console.WriteLine();
         }

		public void HashTabPrint(){
			for (int i = 0; i < ArrayHashTable.Length; i++)
			{
				Console.Write("Reihe " + i + ": " + ArrayHashTable[i].ToString().PadLeft(2));
				Console.WriteLine();

			}
		}

    }
}
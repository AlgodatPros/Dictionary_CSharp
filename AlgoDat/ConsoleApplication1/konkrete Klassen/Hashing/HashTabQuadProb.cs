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
                if (key >= 0 && ArrayHashTable[key] != null)
                {
                    key = (key + (int)Math.Pow(i, 2)) % ArrayHashTable.Length;
					if (ArrayHashTable [key] != null) {

						key = (key - (int)Math.Pow (i, 2)) % ArrayHashTable.Length;
					}
                }
                else if (key >= 0)
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
                 index = (key + (int)Math.Pow(i, 2)) % ArrayHashTable.Length;
				if (index>=0 && ArrayHashTable[index] == key)
                 {
                     return index;
                 } else if(ArrayHashTable[index] != key) {
					index = (key - (int)Math.Pow(i, 2)) % ArrayHashTable.Length;
					if ( index>= 0 && ArrayHashTable[index] == key) {
						return index;
					}
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
				int? elem = ArrayHashTable[i];
				if (elem != null) {
					Console.Write (elem);
					Console.Write (" ");
				}
                 
             }
             Console.WriteLine();
			HashTabPrint ();
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
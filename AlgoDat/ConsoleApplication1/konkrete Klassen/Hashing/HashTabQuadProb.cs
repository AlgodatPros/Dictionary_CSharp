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

            for (int i = 0; i < ArrayHashTable.Length; i++)
            {
				if (key >= 0 && ArrayHashTable [key] != null) {
					int keyplus = (key + (int)Math.Pow (i, 2)) % ArrayHashTable.Length;
					if (keyplus >= 0 && ArrayHashTable [keyplus] == null) {
						ArrayHashTable [keyplus] = elem;
						return true;
					} else if (keyplus >= 0 && ArrayHashTable [keyplus] != null) {
						int keyminus = (key - (int)Math.Pow (i, 2)) % ArrayHashTable.Length;
						if (keyminus >= 0 && ArrayHashTable [keyminus] == null) {
							ArrayHashTable [keyminus] = elem;
							return true;	
						}
					}
				} else if (key >= 0) {
					ArrayHashTable [key] = elem;
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
				//Console.WriteLine (index);
				if (index>=0 && ArrayHashTable[index] == elem)
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
             if (index >= 0)
             {
                 ArrayHashTable[index] = null;
				Console.WriteLine ("Die Zahl an der Stelle "+index+ ": " + ArrayHashTable[index] +  " ist weg");
                 return true;
             }
             else
				Console.WriteLine ("index " + index  );
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
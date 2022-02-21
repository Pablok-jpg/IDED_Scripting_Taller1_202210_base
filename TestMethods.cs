using System.Collections.Generic;
using System;
using System.Linq;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            int[] list = new int[sourceStack.Count];
            
            Stack<int> result = new Stack<int>();
            
            int a;
            foreach (int item in sourceStack)
            {
                a = item;
                foreach (int item_ in sourceStack)
                { 

                    if (a <= item_)
                    {
                        result.Push(-1);
                    }
                    else
                    {
                        a = item_;
                        result.Push(item_);
                    }
                }
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
          
            for (int i = 0; i < sourceArr.Length; i++)
            {
                bool correcto = false;                
                int dividiendo = sourceArr[i];
                Math.DivRem(dividiendo, 2, out int residuo2);
                Math.DivRem(dividiendo, 3, out int residuo3);
                Math.DivRem(dividiendo, 5, out int residuo5);
                Math.DivRem(dividiendo, 7, out int residuo7);

                if (residuo2 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Two);
                    correcto = true;
                }
                else if (residuo3 == 0 && correcto == false)
                {
                    result.Add(sourceArr[i], EValueType.Three);
                    correcto = true;
                }
                else if (residuo5 == 0 && correcto == false)
                {
                    result.Add(sourceArr[i], EValueType.Five);
                    correcto = true;
                }
                else if (residuo7 == 0 && correcto == false)
                {
                    result.Add(sourceArr[i], EValueType.Seven);
                    correcto = true;
                }
                else
                {
                    result.Add(sourceArr[i], EValueType.Prime);
                }                                
            }
            return result;

        }       

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int num = 0;

            EValueType[] Array = sourceDict.Values.ToArray();

            for(int i = 0; i < Array.Length; i++)
            {
                if(Array[i] == type)
                {
                    num++;
                }
            }

            return num;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

             var items = from pair in sourceDict
                     orderby pair.Key descending
                     select pair;

            foreach (KeyValuePair<int, EValueType> pair in items)
            {
                result.Add(pair.Key, pair.Value);
            }

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = new Queue<Ticket>[3];



            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;



             return result;
        }
    }
}
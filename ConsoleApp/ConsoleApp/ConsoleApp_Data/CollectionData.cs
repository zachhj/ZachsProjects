using ConsoleApp_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Data
{
   class CollectionData
   {

      public void ArrayCollection()
      {
         //1-demensional array
         int[] intArray = new int[5];//default
         int[] intArray1 = { 1, 2, 3, 4, 5 };//literal
         var intArray2 = new int[5] {1, 2, 3, 4, 5 };

         //add value 
         intArray[0] = 10;
         var x = intArray1[4];


         //2d array
         int[,] int2DArray = new int[2, 2];
         int[,] int2DArray1 = { { 1, 2, 3 }, { 4, 5, 6 } };
         
         //add and retrieve value
         int2DArray[0, 1] = 40;
         var y = int2DArray1[1, 1]; 


         //3d array
         int[, ,] int3DArray = new int[2, 2, 2];
         int[, ,] int3DArray1 = 
         {
            {
               {1,2}, 
               {3,4}
            },
            {
               {5,6},
               {7,8}
            }
         
         };

         //add and retrieve

         int3DArray[0, 1, 0] = 25;
         var z = int3DArray1[1, 1, 0];

         //1d jagged array
         int[][] intJArray = new int[2][];
         int[][] intJArray1 = 
         { 
            new int[] { 1, 2, 3, 4, 5 }, 
            new int[] { 6, 7, 8 },
            new int[5]
         }; 

         //add and retrieve
         intJArray = new int[][] { new int[3], new int[5] };
         intJArray[0][3] = 5;
         var a = intJArray1[0][1];


         //2d jagged array
         int[][,] int2DJArray = new int[2][,];
         int[][,] int2DJArray1 = 
         { 
            new int[2, 2],
            new int[2,2] { { 1, 2 }, { 3, 4 } } 
         };
      
         //add and retrieve
         int2DJArray[0] = new int[2, 3];
         int2DJArray[1] = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
         var b = int2DJArray1[1][1, 0];
      }

      public void ListCollection()
      {
         //definition
         List<int> intList = new List<int>();
         var intList1 = new List<int> { 1, 2, 3, 4, 5 };
         List<int[]> intList2 = new List<int[]> { new int[] {1,2,3}, new int[] {4,5,6,7} };
         var personList = new List<Person> {new Person("Zachary","Johnson", "Hiles")};

         //add and retrieve
         intList.Add(50);
         intList.ElementAt(0);
         intList.ToArray()[1] = 100;


         var a = intList1[3];
         var b = intList1.ElementAt(1);
         var c = intList1.Where(i => i == 4);
         var d = intList1.FirstOrDefault(i => i == 4);
         var e = intList1.SingleOrDefault(i => i == 4);

         //finding index
         var f = intList1.FindIndex(i => i == 0);
      }



      public void DictionaryCollection()
      {
         Dictionary<string, int> stringIntDictionary = new Dictionary<string, int>
         {
            {"one", 1}, {"two", 2}, {"three", 3}
         };
         Dictionary<int, List<Person>> intPersonDIctionary = new Dictionary<int,List<Person>>();
         Dictionary<Guid, string> example = new Dictionary<Guid, string>();

         //add and retrieve
         stringIntDictionary["class"] = 12;

         stringIntDictionary.ContainsKey("class");
         stringIntDictionary.Add("four", 4);

         if(!stringIntDictionary.ContainsKey("four"))
         {
            stringIntDictionary["four"] = 4;
         }

         try
         {
            stringIntDictionary.Add("four", 4);
         }
         catch(Exception)
         {
            throw;
         }
      }
   }
}

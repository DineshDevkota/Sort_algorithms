using System;
using System.Linq;
namespace Q2
{
    class Q2
    {	
	
	static public int Partition(int [] numbers, int left, int right)

        {

            int pivot = numbers[left];

              while (true)

              {

                while (numbers[left] < pivot)

                    left++;

 

                while (numbers[right] > pivot)

                    right--;

 

                if (left < right)

                    {

                    int temp = numbers[right];

                    numbers[right] = numbers[left];

                    numbers[left] = temp;

                    }

                    else

                    {

                          return right;

                    }

              }

        }

 

        static public void QuickSort_Recursive(int [] arr, int left, int right)

        {

            // For Recusrion

            if(left < right)

            {

                int pivot = Partition(arr, left, right);

 

                if(pivot > 1)

                    QuickSort_Recursive(arr, left, pivot - 1);

 

                if(pivot + 1 < right)

                    QuickSort_Recursive(arr, pivot + 1, right);

            }

        }
	static int BubbleSort(int [] numarray ,int max)

        {

            Console.Write("\nProgram for Ascending order of Numeric Values using BUBBLE SORT");

        
           
 

            Console.Write("\nBefore Sorting   : ");

            for(int k = 0; k < max; k++)

                Console.Write(numarray[k] + " ");

            Console.Write("\n");

 

            for(int i = 1; i < max; i++)

            {

                for(int j = 0; j < max - i; j++)

                {

                    if(numarray[j] > numarray[j + 1])

                    {

                        int temp = numarray[j];

                        numarray[j] = numarray[j + 1];

                        numarray[j + 1] = temp;

                    }

                }

                Console.Write("After iteration " + i.ToString() + ": ");

                for(int k = 0; k < max; k++)

                    Console.Write(numarray[k] +  " ");

                Console.Write("/*** " + (i + 1).ToString() + " biggest number(s) is(are) pushed to the end of the array ***/\n");

            }

 

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");

            for(int i = 0; i < max; i++)

            {

                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");

                Console.Write(numarray[i]);

                Console.Write("\n");

            }

            return 0;

        }   

 	static int InsertionSort( int [] numarray ,int max )

        {

            Console.Write("\nProgram for Ascending order of Numeric Values using INSERTION SORT");    
 	       Console.Write("\nBefore Sorting   : ");
            for(int k = 0; k < max; k++)

                Console.Write(numarray[k] + " ");

            Console.Write("\n");  

 

            for(int i = 1; i < max; i++)

            {

                int j = i;

                while(j > 0)

                {

                    if(numarray[j-1] > numarray[j])

                    {

                        int temp = numarray[j - 1];

                        numarray[j - 1] = numarray[j];

                        numarray[j] = temp;

                        j--;

                    }

                    else

                        break;

                }

                Console.Write("After iteration " + i.ToString() + ": ");

                for(int k = 0; k < max; k++)

                    Console.Write(numarray[k] + " ");

                Console.Write("/*** " + (i + 1).ToString() + " numbers from the begining of the array are input and they are sorted ***/\n");

            }

 

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");

            for(int i = 0; i < max; i++)

            {

                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");

                Console.Write(numarray[i]);

                Console.Write("\n");

            }

            return 0;

        }
       static void Main() 
        {
		int max=0;
		
          Console.Write("\n\nEnter the total number of elements: ");
		
	 while (max==0){
           try{
	 max = Convert.ToInt32(Console.ReadLine());
		}
	catch {
		Console.Write("You entered invalid integer. Enter valid integer :");
		}
 	}

            int [] numarray = new int[max];

 

            for(int i = 0; i < max; i++)

            {	
		try{
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");

                numarray[i] = Convert.ToInt32(Console.ReadLine());
		}
		catch
		{	
		Console.Write("Invalid input [" + (i + 1).ToString() + "] is set to 0");
			numarray[i] = 0;
		}

            }

	
		int[] target1 = new int[max];
		int[] target2 = new int[max];
		int[] target3 = new int[max];
		int[] target4 = new int[max];
		int[] target5 = new int[max];
		Array.Copy(numarray, target1, max);
		Array.Copy(numarray, target2, max);
		Array.Copy(numarray, target3, max);
		Array.Copy(numarray, target4, max);
		Array.Copy(numarray, target5, max);
		Console.WriteLine("~~~~Here goes table of Value and Position~~~~");
		Console.WriteLine("****Position*******************Value**");
		int j=1;
		for (int i = 0; i < max; i++)
		{
   		Console.WriteLine(" *** "+j+ "        ***           "+target1[i]+"***");
   		Console.WriteLine( " *****************************************");
  		j=j+1;
   		
		}
		
		
		Console.WriteLine("\n******************************************************************************************************");
		InsertionSort(target1 , max);
		Array.Copy(target2,numarray, max);
		Console.WriteLine("\n******************************************************************************************************");
		BubbleSort(target2 , max);
		Console.WriteLine("\n******************************************************************************************************");
		Array.Copy(target3,numarray, max);	
	     	QuickSort_Recursive(target3, 0, target3.Length - 1);
		Console.WriteLine("\n QUICKSORT Coming along, By Recursive Method");
		for (int i = 0; i < max; i++)
		{
                Console.WriteLine("Sorted [" + (i + 1).ToString() + "] element: "+target3[i]);

		}
		Console.WriteLine("\n******************************************************************************************************");
		Console.WriteLine("\nREVERSING THE ARRAY");
		Array.Reverse(target4);

	
			for (int i = 0; i < max; i++)
		{
                Console.WriteLine("Reversed [" + (i + 1).ToString() + "] element: "+target4[i]);

		}
		Console.WriteLine();
		Console.WriteLine("\n******************************************************************************************************");
		Console.WriteLine("\nMAX coming now");
		Console.WriteLine("MIN = "+target4.Min()); //1
		Console.WriteLine("\n******************************************************************************************************");
		Console.WriteLine("\nMAX = "+target4.Max());
		double average1 = target4.Average();
		
		Console.WriteLine("\n******************************************************************************************************");
		Console.WriteLine("Average is : "+average1);
           	
            Console.ReadKey();
		
        }
	
    }
}

// start C# script for implement algorithm to get the largest number in array
using System;
namespace myScript{
	//create class
	class MyClass{
		public static int findLargestNumber(int[] myarray)
			{
				int largest=myarray[0];
				foreach (int num in myarray){
					if(num > largest)
					{
						largest = num;
					}
				}
				return largest;
			} 
		public static void Main(String[] args){
			int[] nums = {2,4,3,10,20,5,8};
			int result = findLargestNumber(nums);
			Console.WriteLine(result);
		}
	}
}
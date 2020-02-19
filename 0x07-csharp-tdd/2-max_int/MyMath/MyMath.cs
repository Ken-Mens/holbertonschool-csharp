using System;
using System.Collections.Generic;

namespace MyMath
{
	///<summary> Operations class</summary>
	public class Operations
	{
		///<summary>Method to find the largest in the list of nums</summary>
		public static int Max(List<int> nums)
		{
           int num = 0;
           var ok = nums.Count;
            if (ok != 0)
            {
                nums.Sort();
                num = nums[nums.Count - 1];
            }
            return (num);
		}
	}
}
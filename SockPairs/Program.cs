/*
 * Created by SharpDevelop.
 * User: MANOHAR
 * Date: 11/17/2018
 * Time: 6:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;
using System.Linq;
using System;

namespace HackerRankPractice
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] ar = new int[]{1, 1, 3, 1, 2, 1, 3, 3, 3, 3};
			
			var result = 0;
			var ar1 = ar.Distinct().ToArray();
	    	var dict = new Dictionary<int, int>();
	    	
	    	for(int i=0; i<ar1.Length; i++)
	    	{
	    		dict.Add(ar1[i],0);
	    	}
	    	
	    	var dictKeys = new List<int>(dict.Keys);
	    	
	    	// Get the count of the keys in the Array
	    	for(int r=0; r< dictKeys.Count; r++)
	    	{
	    		int cnt = 0;
		    	for(int i=0; i<ar.Length; i++)
		    	{
		    		if(dictKeys[r] == ar[i])
		    		{
		    			cnt++;
		    		}
		    	}
		    	dict[dictKeys[r]]=  cnt/2;
	    	}
	    	// Add the count to get the number of pairs
	    	foreach(KeyValuePair<int,int> r in dict)
	    	{
	    		result += r.Value;
	    	}
	    	Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
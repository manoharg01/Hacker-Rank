/*
 * Created by SharpDevelop.
 * User: MANOHAR
 * Date: 11/17/2018
 * Time: 8:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CountingValleys
{
	class Program
	{
		public static void Main(string[] args)
		{
			string s = "DDUUUUDD"; 
			
			var sArr = s.ToCharArray();
			int cnt = 0;
			bool isValley = false;
			int numValley = 0;
			
			for(int i=0; i<sArr.Length; i++)
			{
				// if moving below Sea-Level
				if(sArr[i] == 'D' && cnt == 0){
					isValley = true;
					numValley++;
					cnt--;
				}
				// If moving above Sea-Level
				else if(sArr[i]=='U' && cnt == 0){
					isValley = false;
					cnt++;
				}
				// Already on a mountain or in the valley
				else{
					if(sArr[i]== 'U')
						cnt++;
					else
						cnt--;	
				}
				
			}
			Console.WriteLine(numValley);
			Console.ReadLine();
		}
	}
}
/*
 * Created by SharpDevelop.
 * User: MANOHAR
 * Date: 11/18/2018
 * Time: 10:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Jumping_On_Clouds
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] c = new int[]{0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0};
			int step = 0;
            int flag = 0;
            
            for(int i=0; i< c.Length; i++)
            {
                if(flag == 2){
                    flag= 1;
                    continue;
                }
                else if(flag == 1){
                    flag = 0;
                    continue;
                }
                else{
                    
                    if(c[i] != 1)
                    {
                        if(i+1 != c.Length && i+2 != c.Length){
                            if(c[i] == 0 && c[i+1] ==0 && c[i+2]==0){
                                step++;
                                flag = 2;
                            }
                            else if(c[i]==0 && c[i+1]==0){
                                step++;
                                flag=1;
                            }
                            else{
                                step++;
                            }
                        }
                        else if(i+1 != c.Length){
                            if(c[i]==0 && c[i+1]==0){
                                step++;
                                flag = 1;
                            }
                            else{
                                step++;
                                flag=0;
                            }
                        }
                        else{
                            continue;   
                        }
                    }
                    else{
                        step++;
                    }
                }
            }
			Console.WriteLine(step);
			Console.ReadLine();
		}
	}
}
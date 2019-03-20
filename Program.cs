/*
 * Created by SharpDevelop.
 * User: Raspet
 * Date: 3/6/2019
 * Time: 6:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Grimore
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			
			//Introduce and set up game
//			Console.WriteLine("Press any key to start . . . ");
//			Console.ReadKey(true);
			
			InputHandler handler = InputHandler.Instance;
			
			handler.GameSetup();
			//handler.LoadCards();
			
			Console.WriteLine("Press any key to start . . . ");
			Console.ReadKey(true);
			
			AIOutput npc = new AIOutput();
			PCOutput pc = new PCOutput();
			
			
			byte player = 0;
			
			while(!handler.exit)
			{
//				if(player == 0)
//				{
//					player = 1;
//					handler.HandleInput(npc);
//				}
//				else if(player == 1)
//				{
//					player = 0;
//					handler.HandleInput(pc);
//				}
				
				if(Console.ReadLine() != "exit")
				{
					Console.WriteLine("continue...");
				}
				else
					break;
			}
			
			Console.WriteLine("press any key to exit...");
			Console.ReadKey(true);
			
		}
	}
}
/*
 * Created by SharpDevelop.
 * User: Raspet
 * Date: 3/6/2019
 * Time: 7:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Grimore
{
	/// <summary>
	/// Description of PCOutput.
	/// </summary>
	public class PCOutput : PlayerOutput
	{
		public PCOutput()
		{
			
		}
		
		public string GetOutput()
		{
			Console.WriteLine("What's your move?");
			return Console.ReadLine();
		}
	}
}

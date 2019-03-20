/*
 * Created by SharpDevelop.
 * User: Raspet
 * Date: 3/6/2019
 * Time: 7:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Grimore
{
	/// <summary>
	/// Description of AIOutput.
	/// </summary>
	public class AIOutput : PlayerOutput
	{
		public AIOutput()
		{
			
		}
		
		public string GetOutput()
		{
			return Assess();
		}
		
		/// <summary>
		/// TODO Implement to return an assessment from an AIMind
		/// </summary>
		/// <returns></returns>
		private string Assess()
		{
			return null;
		}
		
	}
}
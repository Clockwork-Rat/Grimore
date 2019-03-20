/*
 * Created by SharpDevelop.
 * User: Raspet
 * Date: 3/13/2019
 * Time: 6:23 PM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Grimore
{
	/// <summary>
	/// Description of Monster.
	/// </summary>
	public class Monster //: Card
	{
		public byte Power{get; set;}
		public byte Defense{get; set;}
		public string Name{get; set;}
		public string Type{get; set;}
		public byte Price{get
			{
				return (byte)(((Power * 2) + (Defense)) / 2);
			}
		}
		
		public Monster(byte Power, byte Defense, string Name, string Type)
		{
			this.Power = Power;
			this.Defense = Defense;
			this.Name = Name;
			this.Type = Type;
		}

		public void Play()
		{
			
		}
		
		public override string ToString()
		{
			return string.Format("[Monster Power={0}, Defense={1}, Name={2}, Type={3}, Price={4}]", Power, Defense, Name, Type, Price);
		}
	}
}

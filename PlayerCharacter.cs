/*
 * Created by SharpDevelop.
 * User: Raspet
 * Date: 3/6/2019
 * Time: 6:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Grimore
{
	/// <summary>
	/// Description of PlayerCharacter.
	/// </summary>
	public class PlayerCharacter
	{
		List<Card> Deck = new List<Card>();
		Card[] Hand = new Card[7];
		byte Health{get; set;}
		
		PlayerOutput output;
		
		public PlayerCharacter(bool ai, Game game)
		{
			if(ai)
				output = new AIOutput();
			else
				output = new PCOutput();
		}
		
		int Points{get; set;}
		
		public void addPoints(int Points){this.Points += Points;}
		public void removePoints(int Points){this.Points -= Points;}
		
	}
}

/*
 * Created by SharpDevelop.
 * User: Raspet
 * Date: 3/6/2019
 * Time: 6:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Xml;
using System.Collections.Generic;

namespace Grimore
{
	/// <summary>
	/// Description of InputHandler.
	/// </summary>
	public sealed class InputHandler
	{
		private static InputHandler instance = new InputHandler();
		
		public bool exit = false;
		
		public static InputHandler Instance {
			get {
				return instance;
			}
		}
		
		private InputHandler()
		{
			
		}
		
		public void HandleInput(PlayerOutput input)
		{
			string IN = input.GetOutput();
		}
		
		void LoadCards()
		{
			string CardsText = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?> \n<Doc>";
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"../../../../Cardlists", "*.xml");
			
			for(int i = 0; i < files.Length; i++)
			{
				using(StreamReader sr = new StreamReader(files[i])){
					while(!sr.EndOfStream)
					{
						CardsText += sr.ReadLine() + "\n";
					}
				}
			}
			
			CardsText = CardsText + "</Doc>";
			
			Console.WriteLine(CardsText);
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(CardsText);
			
			List<Monster> MonsterCards = new List<Monster>();
			
			foreach(XmlNode node in doc.ChildNodes[1].ChildNodes)
			{
				if(node.Name.Equals("Monster"))
				{
					string Name = node.ChildNodes[0].InnerText;
					string Type = node.ChildNodes[1].InnerText;
					
					byte Power = (byte)(Convert.ToInt16(node.ChildNodes[2].InnerText));
					byte Defense = (byte)(Convert.ToInt16(node.ChildNodes[3].InnerText));
					Monster monster = new Monster(Power, Defense, Name, Type);
					MonsterCards.Add(monster);
					
					Console.WriteLine("Loaded Monster: " + monster.ToString());
				}
			}
		}
		
		public Game GameSetup()
		{
			LoadCards();
			
			using(StreamReader sr = new StreamReader("..//..//..//Settings//Settings.json"))
			{
				
			}
			return null;
		}
	}
}

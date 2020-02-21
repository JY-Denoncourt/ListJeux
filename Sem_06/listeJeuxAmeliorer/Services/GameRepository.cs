using System.Collections.Generic;
using System.Windows.Documents;
using listeJeuxAmeliorer;
using ListeJeuxAmeliorer.Models;

namespace ListeJeuxAmeliorer.Services
{
	public interface IGameRepository
	{
		List<Game> FindAll();
	}

	public class GameRepository : IGameRepository
	{
		public List<Game> FindAll()
		{
			var result = new List<Game>
			{
				new Game()
				{
					Title = "Kill the goat",
					Description = "You need to kill as many goat as possible!!",
					Editor = "Ubisoft",
					Year = 2010,
					Console = "PS4",
					Rating = 5,
					PicturePath = "Image/chevre1.jpg"
				},
				new Game()
				{
					Title = "Slab the goat",
					Description = "You need to slab as many goat as possible!!",
					Editor = "Epic Game",
					Year = 2015,
					Console = "Xbox3",
					Rating = 9,
					PicturePath = "Image/chevre2.jpg"
				},
				new Game()
				{
					Title = "Run from the goat",
					Description = "You need to run away of the goat as possible!!",
					Editor = "Runtime",
					Year = 2005,
					Console = "PC",
					Rating = 7,
					PicturePath = "Image/chevre3.jpg"
				},
				new Game()
				{
					Title = "Capture the goat",
					Description = "You need to capture as many goat as possible!!",
					Editor = "Gamecon",
					Year = 2000,
					Console = "NES",
					Rating = 4,
					PicturePath = "Image/chevre4.jpg"
				}
			};





			return result;
		}
	}
}
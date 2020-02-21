using System.Collections.Generic;

namespace ListeJeuxAmeliorer.Services
{
	public interface IConsoleRepository
	{
		List<string> FindAll();
	}

	public class ConsoleRepository : IConsoleRepository
	{
		public List<string> FindAll()
		{
			var result = new List<string>();

			result.Add("PS4");
			result.Add("Xbox3");
			result.Add("PC");
			result.Add("NES");

			return result;
		}
	}
}
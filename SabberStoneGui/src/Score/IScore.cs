using SabberStoneCore.Model.Entities;

namespace SabberStoneGui.Score
{
	public interface IScore
	{
		Controller Controller { get; set; }
		int Rate();
	}
}
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneGui.Deck
{
	internal interface IDeck
	{
		string Name { get; set; }
		string Link { get; set; }
		FormatType FormatType { get; set; }
		List<string> CardIds { get; set; }
	}
}

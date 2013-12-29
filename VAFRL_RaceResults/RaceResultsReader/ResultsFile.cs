using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaceResultsReader {
		public class ResultsFile {
				internal HeaderNode Header { get; set; }
				internal RaceNode Race { get; set; }
				internal SlotNodeCollection Slots { get; set; }

		}
}

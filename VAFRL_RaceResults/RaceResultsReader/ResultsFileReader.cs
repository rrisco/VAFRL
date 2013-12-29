using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RaceResultsReader {
		public class ResultsFileReader {
				public bool ReadFiles() {
						// Search for the files to read and insert in the DB
						return ReadFile("some filename");
				}

				private bool ReadFile(string filename) {
						bool processStatus = false;
						ResultsFile resultsFile = ConstructResultsObject(filename);

						return processStatus;
				}

				private ResultsFile ConstructResultsObject(string filename) {
						var constructor = new ResultsConstructor();
						constructor.BuildFileObject(filename);
						return constructor.ResultsFile;
				}

			
		}
}

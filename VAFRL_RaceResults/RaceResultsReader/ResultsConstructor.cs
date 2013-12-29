using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RaceResultsReader {
		internal class ResultsConstructor {
				private ResultsFile _resultsFile;

				public ResultsFile ResultsFile {
						get {
								if (_resultsFile == null)
										throw new InvalidOperationException("Aún no se ha creado un archivo de resultados.");
								return _resultsFile;
						}
				}

				internal void BuildFileObject(string filename) {
						var fileContent = File.ReadAllText(filename);
						var fileNodes = fileContent.Split(new string[1] { "[" }, StringSplitOptions.RemoveEmptyEntries);
						BuildResultsNodes(fileNodes);

				}

				private void BuildResultsNodes(string[] fileNodes) {
						throw new NotImplementedException();
				}

		}
}

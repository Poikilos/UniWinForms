//all rights reserved Jake Gustafson 2008
//created using Kate 2008-10-07
//

using System;
using System.Windows.Forms;

namespace OrangejuiceElectronica {
	public class UniWinFormsSolution {
		UniWinForms[] uwfsarrProject=null;
		string sFile;
		string sName;
		public bool LoadSolution(string sFileX) {
			MessageBox.Show("UniWinFormsSolution Load: Not Yet Implemented");
		}//end LoadSolution
		public bool New(UniWinForms[] uwfsarrProjectFiles, string sSolutionFileX, string sNameX) {
			uwfsarrProject=uwfsarrProjectFiles;//TODO: warn if not null
			sFile=sSolutionFileX;
			sName=sNameX;
		}//end New
	}//end UniWinFormsSolution
}//end namespace

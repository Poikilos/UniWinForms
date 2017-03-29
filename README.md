# UniWinForms (partially deprecated)
The original intent of UniWinForms was to provide a GPL cross-platform winforms designer. However, so far it has just been a holding place for UX/utilities (user experience or random uncategorized tools). Those parts of UniWinForms are being deprecated, so that other programs don't needlessly depend on UniWinForms for trivial UX/utilities code. UniWinForms is kept here because other of my projects hosted here may need it (though they are a continuing part of the UniWinForms UX/utilities deprecation process).

## Changes
* (2017-03-29) moved IWshRuntimeLibrary_UniWinForms.cs back to urltonix (part of UniWinForms UX/utilities deprecation)

## Known Issues
### Alpha (x=done):
* Use RString.SplitScopes
* Use SLN by default (start with a minimalistic version of it for beta)
	(class UWFSolution)
	* use UniWinForm tree to load/save XML projects.
* IF "#region Windows Forms Designer Generated Code" exists, ONLY read/write from there
	* ELSE IF *.Designer.cs file exists, ONLY read/write from there
* import:
	* cmbx
	* sln
	* proj
	* mdp (monodevelop project)
	* mds (monodevelop solution)
* learn to handle line such as:
		((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
	in InitializeComponent
* load resources (i.e. resx files)
	* include in generated build and build.bat files (see TextLocker)
* Add a iReference integer that is >=0 when the UniWinForm should take the value of that UniWinForm in the uniwinform array
	* implement in all UniWinForms read AND write methods.
	* show error and return false upon using UniWinForm get/set methods on a UniWinForm object that is a reference.
	* OPTION 2: make a UniWinFormHandle array that is the ACTUAL array that is used, with only the name and an integer that points to a stack element in the value (uniwinform) array
	
### Beta:
* Make a UniWinForms.dll, and make other projects dynamically link to it (remove UniWinForms cs inclusions).

### Optional:
* Show summaries in a summaries window
* Make code completion show 
	* the function, followed by warnings such as:
		System.dll is not yet referenced by the project
		There is no statement "using System" in this file
		* Methods not yet referenced or used should appear last,
		and methods not referenced nor used should appear very last.
	* the summary if not blank, or summary of last preceding overload that has a summary
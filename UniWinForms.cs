//all rights reserved Jake Gustafson 2007
//created using Kate 2007-08-29
//

using System;
using System.IO;
using System.Collections;
using ExpertMultimedia;//TODO: why is this needed by mcs?
using System.Windows.Forms;//for messagebox only

namespace ExpertMultimedia {
	public class FormType {
		public const int unknown=0;
		public const int comment=1;
	}
	public class UniWinForms {
		#region variables
		public static readonly char[] carrHexUpper=new char[] {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
		public static readonly char[] carrHexLower=new char[] {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f'};
		public static string[] sarrNewLine={Environment.NewLine,"\n","\r"};
		UniWinForm[] formarr=null;
		string[] sarrFile=null;//ALL cs files in current folder
		public static readonly string[] sarrBrowser=new string[]{"firefox","firefox-bin","mozilla","mozilla-firefox","galleon","iceweasel","icecat"};
		public static bool bCreatedOutput=false;
		public static string sFileOutput="1.Output.txt";//Environment.GetFolderPath(Environment.SpecialFolder.Personal)+"/lib/urltonix/1.Output.txt";
		public static int iOutputs=0;
		public static int iMaxOutputs=1000;
		private static string sDirSepChar;//DirectorySeparatorChar
		public static string DirectorySep {
			get {
				return sDirSepChar;
			}
		}
		private string[] sarrCodeSeg=null;
		#endregion variables
		#region constructors
		static UniWinForms() {//static constructor
			sDirSepChar=char.ToString(System.IO.Path.DirectorySeparatorChar);
		}
		#endregion constructors
		#region output/reporting
		public static void WriteLine(Exception exn) {
			Console.Error.WriteLine("Error in an unknown UniWinForms component: "+exn.ToString());
			Console.Error.WriteLine();
		}
		//public static void WriteLine(string sMsg) {
		//	Write(sMsg+Environment.NewLine);
		//}
		//public static void WriteLine() {
		//	Write(Environment.NewLine);
		//}
		private static void AppendForever(string sMsg) {
			StreamWriter swNow=null;
			if (!bCreatedOutput) {
				//if (Exists(sFileOutput)) File.Delete(sFileOutput);
				swNow=File.CreateText(sFileOutput);
				bCreatedOutput=true;
				swNow.Write(sMsg);
				swNow.Close();
			}
			else {
				swNow=File.AppendText(sFileOutput);
				swNow.Write(sMsg);
				swNow.Close();
			}
		}
		//Form mainformNow=null;
		//public string sStatus {
		//	set {
		//		if (mainformNow!=null) mainformNow.sStatus=value;
		//	}
		//}
/*
		public static void Write(string sMsg) {
			try {
				UniWinForms.StringToConsole(sMsg);
				if (sMsg!=Environment.NewLine&&sMsg.IndexOf(Environment.NewLine)>-1) iOutputs++;
				if (iOutputs<iMaxOutputs) {
					AppendForever(sMsg);
				}
				else if (iOutputs==iMaxOutputs) {
					AppendForever("MAXIMUM MESSAGES REACHED--This is the last message that will be shown: "+sMsg);
				}
			}
			catch {//(Exception exn) {
				try {
					//IgnoreExn(exn,"Write","trying to append output text file");
					StreamWriter swNow=null;
					if (!bCreatedOutput) {
						swNow=File.CreateText(sFileOutput);
						bCreatedOutput=true;
						swNow.Write(sMsg);
						swNow.Close();
					}
				}
				catch {
					//IgnoreExn(exn2,"Write","trying to create new output text file");//ignore since "error error"
				}
			}
		}//end Write
*/
		///<summary>
		///Detects *.cs in the same folder as the given file.
		///</summary>
		public bool Load(string sFileX) {
			//TODO: ask to save first if data is loaded
			bool bGood=false;
			string sVerb="starting";
			StreamReader streamIn=null;
			string sAllData="";
			int iCountCS=0;
			ArrayList alFiles=new ArrayList();
			try {
				alFiles.Add("test1");
				alFiles.Add("test2");
				iCountCS=2;
				if (iCountCS>0) {
					sarrFile=new string[alFiles.Count];
					int iNow=0;
					foreach (string sFileNow in alFiles) {
						sarrFile[iNow]=sFileNow;
						iNow++;
					}
				}
				else sarrFile=null;
				streamIn=new StreamReader(sFileX);
				sAllData=streamIn.ReadToEnd();
				//TODO: finish this -- parse data into UniWinForm objects (linear code packets)
				MessageBox.Show("Load: Not Yet Implemented","UniWinForms");
				bGood=true;
			}
			catch (Exception exn) {
				bGood=false;
				Console.Error.WriteLine("Error in UniWinForms Load(\""+sFileX+"\") while "+sVerb+":");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
			return bGood;
		}
		public object[] FormNameStringsToObjectArray() {
			object[] objectarrReturn=null;
			if (sarrFile!=null&&sarrFile.Length!=0) {
				objectarrReturn=new object[sarrFile.Length];
				for (int iNow=0; iNow<sarrFile.Length; iNow++) {
					objectarrReturn[iNow]=sarrFile[iNow];
				}
			}
			return objectarrReturn;
		}
		public bool Save(string sFileX) {
			bool bGood=false;
			string sVerb="starting";
			StreamWriter streamOut=null;
			string sAllData="";
			try {
				//streamOut=new StreamWriter(sFileX);
				//TODO: finish this -- write all packets to file
				//for (int iNow=0; iNow<iPackets; iNow++) {
				//}
				MessageBox.Show("Save: Not Yet Implemented","UniWinForms");
				bGood=true;
			}
			catch (Exception exn) {
				bGood=false;
				Console.Error.WriteLine("Error in UniWinForms Save(\""+sFileX+"\") while "+sVerb+":");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
			return bGood;
		}
		public static string SpecialFolderToString(string sName) {
			string sReturn="";
			System.Environment.SpecialFolder specialfolderType;
			foreach (System.Environment.SpecialFolder specialfolderNow in System.Enum.GetValues(typeof(Environment.SpecialFolder))) {
				specialfolderType = specialfolderNow;
				if (sName==specialfolderType.ToString()) {
					sReturn=System.Environment.GetFolderPath(specialfolderType);
					break;
				}
				//Console.WriteLine(System.Environment.GetFolderPath(specialfolderType));
			}
			return sReturn;
		}
		public static DirectoryInfo SpecialFolderToDirectoryInfo(string sName) {
			string sPath=SpecialFolderToString(sName);
			return new DirectoryInfo(sPath);
		}
		#endregion output/reporting
		#region utilities
		private static int iLastLUID=-1;
		public static int GenLUID() {
			iLastLUID++;
			return iLastLUID;
		}
		public static bool FileContains(string sFile, string sData) {
			return FileContainsAscii(sFile,sData)||FileContainsUnicode(sFile,sData);
		}
		public static bool FileContains(string sFile, byte[] byarrData) {
			int iMatches=0;
			try {
				Chunker chunkerX=new Chunker(sFile, false);
				byte valNow;
				long nFileUnits=chunkerX.Length;//use byte length since ascii
				iMatches=0;
				for (long iNow=0; iNow<nFileUnits; iNow++) {
					if (!chunkerX.Read(out valNow)) break;
					else if (valNow==byarrData[iMatches]) {
						iMatches++;
						if (iMatches==byarrData.Length) break;
					}
					else iMatches=0;
				}
			}
			catch (Exception exn) {
				string sExn=exn.ToString();
				if (sExn.IndexOf("FileNotFoundException")>-1) sExn="FileContains(...,binary): Cannot find  \""+sFile+"\" for binary search-may be broken symbolic link or in different relative path.";
				Console.Error.WriteLine(sExn);
			}
			return iMatches==byarrData.Length;
		}//end FileContains(...,byarrData)
		public static bool FileContainsAscii(string sFile, string sData) {
			int iMatches=0;
			try {
				Chunker chunkerX=new Chunker(sFile, false);
				char valNow;
				long nFileUnits=chunkerX.Length;//use byte length since ascii
				iMatches=0;
				//UniWinForms.WriteLine();//debug only
				//UniWinForms.WriteLine(sFile+" (looking for "+sData+" in "+chunkerX.Length.ToString()+"-byte file)");//debug only
				for (long iNow=0; iNow<nFileUnits; iNow++) {
					if (!chunkerX.ReadAscii(out valNow)) break;
					else if (valNow==sData[iMatches]) {
						iMatches++;
						if (iMatches==sData.Length) break;
					}
					else iMatches=0;
					//UniWinForms.Write((iNow==0?"":",")+(valNow).ToString());//+"@"+chunkerX.Position.ToString());//debug only
				}
				//UniWinForms.WriteLine();//debug only
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Error in UniWinForms FileContainsAscii(\""+sFile+"\",string)");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
			return iMatches==sData.Length;
		}//end FileContainsAscii
		public static bool FileContainsUnicode(string sFile, string sData) {
			int iMatches=0;
			try {
				Chunker chunkerX=new Chunker(sFile, false);
				char valNow;
				long nFileUnits=UniWinForms.ChunksNeeded(chunkerX.Length,2);
				iMatches=0;
				for (long iNow=0; iNow<nFileUnits; iNow++) {
					if (!chunkerX.ReadUnicode(out valNow)) break;
					else if (valNow==sData[iMatches]) {
						iMatches++;
						if (iMatches==sData.Length) break;
					}
					else iMatches=0;
				}
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Error in UniWinForms FileContainsUnicode(\""+sFile+"\",string)");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
			return iMatches==sData.Length;
		}//end FileContainsUnicode
		public static bool IsBrowserProcessName(string sProcessName) {
			bool bFound=false;
			sProcessName=sProcessName.ToLower();
			for (int iNow=0; iNow<sarrBrowser.Length; iNow++) {
				if (sProcessName.StartsWith(sarrBrowser[iNow])) {
					bFound=true;
					break;
				}
			}
			return bFound;
		}//end IsBrowserProcessName
		public static string[] ProcessesList_Framework() {
			ArrayList alNow=new ArrayList();
			System.Diagnostics.Process[] procarrNow = System.Diagnostics.Process.GetProcesses();
			for (int i=0; i<procarrNow.Length; i++) {
				alNow.Add(procarrNow[i].ProcessName);
			}
			string[] sarrReturn=null;
			int iNow=0;
			if (alNow.Count>0) {
				sarrReturn=new string[alNow.Count];
				foreach (string sNow in alNow) {
					sarrReturn[iNow]=sNow;
					iNow++;
				}
			}
			else {
				sarrReturn=new string[]{""};
			}
			return sarrReturn;
		}//end ProcessesList_Framework
		public static string SystemCommand(string sCommandString, bool bWait_AndReturnOutput) {
			int iSpace=-1;
			string sReturn="";
			if (sCommandString!=null) {
				iSpace=sCommandString.IndexOf(" ");
				string sCommand=sCommandString;
				string sArgs="";
				if (iSpace>-1&&(sCommandString.Length>iSpace+1)) {
					sCommand=sCommandString.Substring(0,iSpace);
					sArgs=sCommandString.Substring(iSpace+1);
				}
				System.Diagnostics.ProcessStartInfo psi =
					new System.Diagnostics.ProcessStartInfo(sCommand);
				psi.RedirectStandardOutput = bWait_AndReturnOutput;
				psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				psi.UseShellExecute = !bWait_AndReturnOutput;//NOTE: must be false when redirecting output!
				psi.Arguments=sArgs;
				System.Diagnostics.Process procNow = System.Diagnostics.Process.Start(psi);
				System.IO.StreamReader srSelf=null;
				if (bWait_AndReturnOutput) srSelf = procNow.StandardOutput;
				procNow.WaitForExit(2000);//2000 is a maximum not a minimum--leave blank to wait indefinitely
				if (bWait_AndReturnOutput) {
					if (procNow.HasExited) {
						sReturn = srSelf.ReadToEnd();
					}
				}
			}//end if not null
			return sReturn;
		}//end SystemCommand
		public static bool EnvironmentIsWindows() {
			return Environment.OSVersion.ToString().IndexOf("Win")>=0;
		}
		public static string[] ProcessesList() {
			string[] sarrReturn=null;
			ArrayList alNow=null;
			try {
				if (UniWinForms.EnvironmentIsWindows()) sarrReturn=ProcessesList_Framework();
				else {
					alNow=new ArrayList();
					//string sTempFile=Environment.GetFolderPath(Environment.SpecialFolder.Personal)+"/ps.tmp";
					//string sTempFile=UniWinForms.SpecialFolderToString("Personal")+"/ps.tmp";
					
					string sProcesses=UniWinForms.SystemCommand("ps -A",true);
					//WriteLine("processing result:\""+sProcesses+"\"");
					//UniWinForms.SystemCommand("ps -A > \""+sTempFile+"\"",false);
					//System.Diagnostics.Process.Start("ps","-A > \"sTempFile\"");
					string[] sarrProcess=UniWinForms.ReadAllLines(sProcesses);
					//string[] sarrProcess=UniWinForms.FileToStringArray(sTempFile);
					string sNow;
					int iOpener, iCloser;
					if (sarrProcess!=null) {
						for (int iProcessLine=0; iProcessLine<sarrProcess.Length; iProcessLine++) {
							int iLastMarker=sarrProcess[iProcessLine].LastIndexOf(":");
							if (iLastMarker>-1&&sarrProcess[iProcessLine].Length>iLastMarker+4) {
								sNow=sarrProcess[iProcessLine].Substring(iLastMarker+4);
								iOpener=sNow.IndexOf("[");
								iCloser=sNow.IndexOf("]");
								if ( iOpener==0 //ONLY if StartsWith("["), since can be like "init [5]"
										&& iCloser>iOpener
										&& (iCloser-iOpener>0) ) {
									sNow=sNow.Substring(iOpener,iCloser-iOpener);
								}
								alNow.Add(sNow);
							}//end if has enough data to be a process list item
							//else WriteLine("failed to parse "+sarrProcess.Length+" lines of output for \"ps -A\" (process list): line["+iProcessLine.ToString()+"]=\""+sarrProcess[iProcessLine]+"\"");
						}
					}
					int iNow=0;
					if (alNow.Count>0) {
						sarrReturn=new string[alNow.Count];
						foreach (string sLineX in alNow) {
							sarrReturn[iNow]=sLineX;
							iNow++;
						}
					}
					else {
						sarrReturn=new string[]{""};
					}
				}//else assume linux and try to get processes manually\
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Error in UniWinForms ProcessesList()");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
			return sarrReturn;
		}//end ProcessesList
		public static string AnOpenBrowserName() {
			string sReturn=""; //bool bFound=false;
			Console.WriteLine("ProcessName:ProcessID");
			string[] sarrNow=ProcessesList();
			for ( int iNow=0; iNow<sarrNow.Length ; iNow++) {
				//WriteLine("            analyzing:\""+sarrNow[iNow]+"\"");
				if (IsBrowserProcessName(sarrNow[iNow])) {
					sReturn=sarrNow[iNow];//bFound=true;
					break;
				}
			}
			return sReturn;
		}//end AnOpenBrowserName
		//public static bool MoveToHeir(string sHaystack, string sOpener, string sCloser, int iStart) {
			
		//}
		public static string RemoveEndsWhiteSpace(string sNow) {
			while ((sNow.EndsWith("\t")||sNow.EndsWith("\n")||sNow.EndsWith("\r")||sNow.EndsWith(" ") ) && sNow.Length>0 ) sNow=sNow.Substring(0,sNow.Length-1);
			while ((sNow.StartsWith("\t")||sNow.StartsWith("\n")||sNow.StartsWith("\r")||sNow.StartsWith(" ") ) && sNow.Length>0 ) sNow=sNow.Substring(1);
			return sNow;
		}
		///<summary>
		///
		///</summary>
		///<returns>string that was found, else null (not ""!) and iMoveMePastAnyNeedle is moved to val.Length</returns>
		public static string MovePastAny(string sHaystack, ref int iMoveMePastAnyNeedle, string[] sarrNeedles) {
			string sFound=null;
			if (sHaystack!=null&&sHaystack!="") {
				if (sarrNeedles!=null) {
					while (iMoveMePastAnyNeedle<sHaystack.Length) {//for (int iNow=0; iNow<sHaystack.Length; iNow++) {
						for (int iCheck=0; iCheck<sarrNeedles.Length; iCheck++) {
							if (CompareAt(sHaystack,sarrNeedles[iCheck],iMoveMePastAnyNeedle)) {
								sFound=sarrNeedles[iCheck];//DOES break outer loop (see below this loop)
								iMoveMePastAnyNeedle+=sarrNeedles[iCheck].Length;//moves past
								break;
							}
						}
						if (sFound==null) iMoveMePastAnyNeedle++;
						else break;
					}//end while not reached end
				}//end if needles not null
			}//end if usable haystack
			else iMoveMePastAnyNeedle=0;
			return sFound;
		}//end MovePastAny
		///<summary>
		///moves to next occurrance of sNeedle, else sets iMoveMe to val.Length
		///</summary>
		///<returns>false if reaches end first (iMoveMe will still be moved to sHaystack.Length)</return>
		public static bool MoveTo(string sHaystack, ref int iMoveMe, string sNeedle) {
			bool bFound=false;
			if (sHaystack!=null&&sHaystack!="") {
				if (sNeedle!=null) {
					while (iMoveMe<sHaystack.Length) { //for (int iNow=0; iNow<sHaystack.Length; iNow++) {
						if (CompareAt(sHaystack,sNeedle,iMoveMe)) {
							//iMoveMe=iNow+sNeedle.Length;//move past
							bFound=true;
							break;
						}
						else iMoveMe++;
					}
				}
			}
			else iMoveMe=0;
			return bFound;
		}//end MoveTo
		public static string ReadLine(string val, ref int iMoveMePastNewLine) {
			string sLine=null;
			if (val!=null&& ((val.Length)>iMoveMePastNewLine) ) {
				int iStart=iMoveMePastNewLine;
				string sFound=MovePastAny(val, ref iMoveMePastNewLine, sarrNewLine);
				if (sFound!=null&&sFound!="") {
					if (iMoveMePastNewLine-iStart>sFound.Length) sLine=val.Substring(iStart,(iMoveMePastNewLine-sFound.Length)-iStart);
					else sLine="";
				}
			}
			return sLine;
		}
		public static string[] ReadAllLines(string val) {
			ArrayList alNow=null;
			string[] sarrReturn=null;
			string sLine;
			int iCursor=0;
			try {
				alNow=new ArrayList();
				while ((sLine=UniWinForms.ReadLine(val,ref iCursor)) != null) {
					alNow.Add(sLine);
				}
				if (alNow.Count>0) {
					sarrReturn=new string[alNow.Count];
					int iNow=0;
					foreach (string sNow in alNow) {
						sarrReturn[iNow]=sNow;
						iNow++;
					}
				}
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Error in UniWinForms ReadAllLines(string data)");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
			if (sarrReturn==null) sarrReturn=new string[]{""};
			return sarrReturn;
		}//end ReadAllLines
		public static void StringToConsole(string sMsg) {
			int iNow=0;
			string sCumulative="";
			if (sMsg!=null) {
				while (iNow<sMsg.Length) {
					if (CompareAt(sMsg,Environment.NewLine,iNow)) {
						Console.WriteLine(sCumulative);
						iNow+=Environment.NewLine.Length;
						sCumulative="";
					}
					else {
						sCumulative+=char.ToString(sMsg[iNow]);
						iNow++;
					}
				}
				if (sCumulative!="") Console.Write(sCumulative);
			}
		}
		public static bool CompareAt(string sHaystack, string sNeedle, int iAtHaystack) {
			int iMatches=0;
			int iNeedle=0;
			if (sHaystack!=null&&sHaystack!=""&&sNeedle!=null&&sNeedle!="") {
				iNeedle=sNeedle.Length;
				for (int iNow=0; iNow<iNeedle&&iAtHaystack<sHaystack.Length; iNow++) {
					if (sHaystack[iAtHaystack]==sNeedle[iNow]) iMatches++;
					iAtHaystack++;
				}
			}
			return iMatches!=0&&iMatches==iNeedle;
		}
		public static void StripPercentEscapedByRef(ref string val) {
			int iLoc=0;
			bool bSequenceFound=true;
			bool bGood=false;
			string sVerb="parsing argument";
			try {
				while (iLoc>-1 && bSequenceFound) {
					iLoc=val.IndexOf("%");
					if (iLoc>-1) {
						if ((val.Length-(iLoc+1))>=2) {
							sVerb="getting character 0x"+val.Substring(iLoc+1,2)+"";
							ReplaceChunkByRef( ref val, iLoc, 3, char.ToString((char)HexToInt(val.Substring(iLoc+1,2))) );
							bGood=true;
						}
						else bSequenceFound=false;
					}
				}
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Exception error in StripPercentEscapedByRef while "+sVerb+" {val:\""+val+"\"}:"+exn.ToString());
				Console.Error.WriteLine();
			}
		}
		public static void ReplaceChunkByRef(ref string sNow, int iStart, int iLen, string sNew) {
			try {
				sNow=sNow.Substring(0,iStart)+sNew+sNow.Substring(iStart+iLen);
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Exception error in ReplaceChunkByRef while parsing arguments {sNow:\""+sNow+"\"; iStart:"+iStart.ToString()+"; iLen:"+iLen.ToString()+"; sNew:"+sNew+"}:"+exn.ToString());
				Console.Error.WriteLine();
			}
		}
		public static int HexValue(char cNow) {
			for (int iNow=0; iNow<carrHexLower.Length; iNow++) {
				if (cNow==carrHexLower[iNow]||cNow==carrHexUpper[iNow]) return iNow;
			}
			return 0;
		}
		public static int HexToInt(string sHex) {
			int iReturn=0;
			int iMultiplier=1;
			sHex=sHex.ToLower();
			if (sHex.Length>1&&sHex.EndsWith("h")) sHex=sHex.Substring(0,sHex.Length-1);
			if (sHex.Length>2&&sHex.StartsWith("0x")) sHex=sHex.Substring(2);
			if (sHex!=null&&sHex.Length>0) {
				for (int iNow=sHex.Length-1; iNow>=0; iNow--) {
					iReturn+=iMultiplier*HexValue(sHex[iNow]);
					iMultiplier*=16;
				}
			}
			else Console.Error.WriteLine("HexToInt error: value \""+sHex+"\" should be 2 characters");
			return iReturn;
		}//end HexToInt
		
		/*
			Environment.SpecialFolder.ApplicationData
			Environment.SpecialFolder.System
			Environment.SpecialFolder.CommonApplicationData
			Environment.SpecialFolder.CommonProgramFiles
			Environment.SpecialFolder.Cookies
			Environment.SpecialFolder.Desktop
			Environment.SpecialFolder.DesktopDirectory
			Environment.SpecialFolder.Favorites
			Environment.SpecialFolder.History
			Environment.SpecialFolder.InternetCache
			Environment.SpecialFolder.LocalApplicationData
			Environment.SpecialFolder.MyComputer
			Environment.SpecialFolder.MyMusic
			Environment.SpecialFolder.MyPictures
			Environment.SpecialFolder.Personal
			Environment.SpecialFolder.ProgramFiles
			Environment.SpecialFolder.Programs
			Environment.SpecialFolder.Recent
			Environment.SpecialFolder.SendTo
			Environment.SpecialFolder.StartMenu
		*/
		
		public static string[] FileToStringArray(string sFile) {
			string[] sarrReturn=null;
			string sVerb="loading file";
			try {
				if (File.Exists(sFile)) {
					StreamReader srNow=new StreamReader(sFile);//File.OpenRead(sFile);
					sVerb="getting data";
					string sLine;
					int iNow=0;
					ArrayList alNow=new ArrayList();
					while ((sLine=srNow.ReadLine()) != null) {
						sVerb="getting line ["+iNow.ToString()+"]";
						alNow.Add(sLine);
						iNow++;
					}
					iNow=0;
					sVerb="closing file";
					srNow.Close();
					sVerb="processing data";
					if (alNow.Count>0) {
						sarrReturn=new string[alNow.Count];
						foreach (string sNow in alNow) {
							sVerb="processing line ["+iNow.ToString()+"]";
							sarrReturn[iNow]=sNow;
							iNow++;
						}
					}
					sVerb="finished";
				}
				else {
					Console.Error.WriteLine("FileToStringArray error: \""+sFile+"\" does not exist.");
					sVerb="cancelling";
				}
			}
			catch (Exception exn) {
				sarrReturn=null;
				Console.Error.WriteLine("Exception error in FileToStringArray while "+sVerb+": "+exn.ToString());
				Console.Error.WriteLine();
			}
			return sarrReturn;
		}//end FileToStringArray
		public static string FileToString(string sFile) {
			return FileToString(sFile, Environment.NewLine);
		}
		public static string FileToString(string sFile, string sToInsertAfterNewLine) {
			string[] sarrNow=FileToStringArray(sFile);
			string sReturn="";
			if (sarrNow!=null) {
				for (int iNow=0; iNow<sarrNow.Length; iNow++) {
					if (iNow!=0) sReturn+=sToInsertAfterNewLine;
					sReturn+=sarrNow[iNow];
				}
			}
			return sReturn;
		}//end FileToString
		public static int ChunksNeeded(int iUnits, int iUnitsPerChunk) {
			return (int)(iUnits/iUnitsPerChunk)+(iUnits%iUnitsPerChunk!=0?1:0);
		}
		public static long ChunksNeeded(long iUnits, long iUnitsPerChunk) {
			return (long)(iUnits/iUnitsPerChunk)+(iUnits%iUnitsPerChunk!=0?1:0);
		}
		#endregion utilities
	}//end UniWinForms
}//end namespace

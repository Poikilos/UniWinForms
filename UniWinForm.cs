//all rights reserved Jake Gustafson 2007
//created using Kate 2007-09-17 (code moved from UniWinForms.cs)
//

using System;

namespace OrangejuiceElectronica {
	public delegate bool StringDelegate(string sMsg);
	public class UniWinForm {
		public string sData="";//parent in uniwinforms.formarr
		public int iType=0;
		public int iParent;//parent in uniwinforms.formarr
		//public int iStart;
		//public int iEnd;//include any comments

		//public static bool bShowMissingConstructorArgsError=true;
		public UniWinForm() {
			//if (bShowMissingConstructorArgsError) {
			//	MessageBox.Show("Warning: default constructor must be used for UniWinForm.  Now you have to use Init method.");
			//	bShowMissingConstructorArgsError=false;
			//}
			iType=FormType.unknown;
			sData="";
		}
		public UniWinForm(string sDataX) {
			Init(sDataX, FormType.unknown);
		}
		public UniWinForm(string sDataX, int iTypeX) {//int iParentX, int iStartX, int iEndX) {
			Init(sDataX,iTypeX);
		}

		public bool Init(string sDataX, int iTypeX) {
			sData=sDataX;
			iType=iTypeX;
			//iParent=iParentX;
			//iStart=iStartX;
			//iEnd=iEndX;
			return true;
		}

#region unused (to end)
		/*
		public string sType="Form";//byte, ushort, int, long, float, double, decimal, Point, Rectangle, Form
		private string sValue="";//0.0M;//only valid if IsLeaf
		public string Text {
			get {
				return sValue;
			}
			set {
				sValue=value;
			}
		}
		private int iUsed=0;
		int iCol=0;//location in text file--starting at 0
		int iRow=0;//location in text file--starting at 0
		public UniWinForm[] subarr=null;
		public string Name {
			get {
				return sName;
			}
			set {
				sName=value;
			}
		}
		private string sName="";
		private UniWinForm formParent=null;
		public UniWinForm Parent {
			get {
				return formParent;
			}
			set {
				formParent=value;
				//TODO: parent-changed handler here
			}
		}

		public int Maximum {
			get {
				return subarr!=null?subarr.Length:0;
			}
			set {
				try {
					if (value>0) {
						int iNew=value;
						if (value<iUsed) {
							iNew=iUsed;
							Console.Error.WriteLine("Warning: Tried to set "+iUsed+"-branch set to "+value.ToString()+" Maximum so reverted Maximum to length.");
						}
						UniWinForm[] subarrNew=new UniWinForm[iNew];
						for (int iNow=0; iNow<iNew; iNow++) {
							if (iNow<Maximum) subarrNew[iNow]=subarr[iNow];
							else subarrNew[iNow]=new UniWinForm();//debug performance and memory usage
						}
					}
					else {
						Console.Error.WriteLine("Error, cannot set form"+SpaceThenName+" maximum branches to "+value.ToString());
						Console.Error.WriteLine();
					}
				}
				catch (Exception exn) {
					Console.Error.WriteLine("Exception error setting Maximum for form"+SpaceThenName+" to "+value.ToString());
					Console.Error.WriteLine();
				}
			}//end set
		}//end Maximum

		public string SpaceThenName {
			get {
				if (sName!=null&&sName!="") return " "+sName;
				else return "";
			}
		}
		#region thread-safe callback
		//<summary>
		//locally-unique identifier (local to this run of the program)
		//</summary>
		private int iLUID=-1;//set in constructor
		bool bContinueCurrentAction=true;
		public bool StatusCallback(string sMsg) {
			bool bReturn=bContinueCurrentAction;
			Text=sMsg;//TODO: put the text somewhere better?
			bContinueCurrentAction=true;//ok since calling function will get it's original value --true value here is ONLY used for the next method that uses StatusCallback.
			return bReturn;
		}
		//usages:
		// DoSomeThingIntenseInSameThread(new StringDelegate(StatusCallback));
		//or
		// SomeObject.delCallback=new StringDelegate(StatusCallback);
		// Thread.Start(someobject.DoSomethingIntense());
		//or
		// DoSomeThingIntenseInSameThread(new StringDelegate(StatusCallback));
		#endregion thread-safe callback

		private static bool bShowNoParentError=true;
		public UniWinForm() {
			Init(10);//,null);
			if (bShowNoParentError) {
				MessageBox.Show("Warning: Parent is not set");
				bShowNoParentError=false;
			}
		}
		public UniWinForm(UniWinForms ParentX) {
			Init(10,ParentX);
		}
		private void Init(int SetMaximum) {//, UniWinForms ParentX) {
			//iLUID=UniWinForms.GenLUID();
			Maximum=SetMaximum;//IS resized when needed
			Parent=ParentX;
		}
		public void SetFuzzyMaximum(int iFuzzyMinimum) {
			if (iFuzzyMinimum>Maximum) Maximum=(int)((double)iFuzzyMinimum*1.5);
		}
		public bool IsVariable {
			get {
				return subarr==null;
			}
		}
		///<summary>
		///Returns true if this is a lowest-level form and not a variable of a form.
		///</summary>
		public bool IsTwig {
			get {
				bool bFoundSubform=false;
				if (!IsVariable) {
					for (int iNow=0; iNow<subarr.Length; iNow++) {
						if (!subarr[iNow].IsVariable) {
							bFoundSubform=true;
							break;
						}
					}
				}
				return !(IsVariable||bFoundSubform);
			}
		}
		public UniWinForm Root {
			get {
				return IsRoot?this:Parent.Root;
			}
		}
		public bool IsRoot {
			get {
				return formParent==null;
			}
		}
		public int GetForcedInt(string sDotNotationVar) {
			//TODO: resolve Position.X etc
			Console.Error.WriteLine("UniWinForm GetForcedInt is not yet implemented!");
			Console.Error.WriteLine();
			return -1;
		}
		public bool SetForced(string sDotNotationVar, string sValue) {
			bool bGood=false;
			int iX=sValue.IndexOf("new");
			int iIndexTarget=-1;
			int iOpener=-1;
			if (iX>-1) {
				iOpener=iX;
				UniWinForms.MoveTo(sValue,ref iOpener,"(");
				string[] sarrNow=null;///TODO: finish this called method!!!  SplitConstructorValues(sValue,iOpener);
				//int iCloser=MoveToHier(sValue,"(",")",iOpener);
				///TODO: must use recursion here instead of getting last dot -- only set value if sDotNotationVar specifies leaf (even then, it is not a leaf if it is a Point i.e. Location or ClientRectangle etc.)
				//int iLastDot=sDotNotationVar.LastIndexOf(".");
				//if (iLastDot>-1) {
				//	iIndexTarget=InternalIndexOf(RemoveEndsWhiteSpace(sDotNotationVar));
				//}
				for (int iNow=0; iNow<sarrNow.Length; iNow++) {
					if (sarrNow[iNow].IndexOf("(")>-1) {
						//TODO: string sNow=Root.ResolveValue(sarrNow[iNow]);
						//TODO: string sTypeNow=Root.ResolveType(sarrNow[iNow]);
						//TODO: finish this (check if any additions are necessary, and finish called methods
						Console.Error.WriteLine("UniWinForm SetForced is not yet implemented!");
					}
				}
			}//end for iX
			bGood=true;
			return bGood;
		}//end SetForced
*/
#endregion unused (to end)
	}//end class UniWinForm
}
/*
 *  Created by SharpDevelop (To change this template use Tools | Options | Coding | Edit Standard Headers).
 * User: Jake Gustafson (Owner)
 * Date: 9/22/2006
 * Time: 10:39 PM
 * 
 */

using System;
//using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace OrangejuiceElectronica {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm {
		int iCalcHH;
		int iCalcMM;
		int iCalcSS;
		int iCalcFF;
		int iCalcFrames;
		decimal dCalcFrameRate;
		public static MainMenu mainmenu;
		public static MenuItem miAbout;
		public static MenuItem miHelpMenu;
		public static MenuItem miPaste;
		public static MenuItem miCopy;
		public static MenuItem miCut;
		public static MenuItem miEditMenu;
		public static MenuItem miExit;
		public static MenuItem miSave;
		public static MenuItem miOpen;
		public static MenuItem miFileMenu;
		public static bool bClosedSafe=false;
		public static string sLog="1.Temp.txt";
		public static string sMyName="UniWinForms";
		public static string sLastMsg="";
		public static MainForm mainformNow=null;
		public static SplashScreen splashscreen=null;
		public static string sStatus {
			set {
				sLastMsg=value;
				try {
					mainformNow.Text=sMyName+" "+value;
				}
				catch {
				}
				Application.DoEvents();
			}
			get {
				return sLastMsg;
			}
		}
		[STAThread]
		public static void Main(string[] args) {
			Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			mainformNow=new MainForm();
			Application.Run(mainformNow);
		}
		
		public MainForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Thread th = new Thread(new ThreadStart(DoSplash));
			//th.ApartmentState = ApartmentState.STA;
			//th.IsBackground=true;
			//th.Start();
			splashscreen = new SplashScreen();
			splashscreen.Show();
			Application.DoEvents();
			Thread.Sleep(3000);
			splashscreen.Close();
			//th.Abort();
			//Thread.Sleep(1000);
			
			mainmenu = new MainMenu();

			miFileMenu = new MenuItem();
			miFileMenu.Text = "&File";
			mainmenu.MenuItems.Add(miFileMenu);
			
			miOpen = new MenuItem();
			miOpen.Text = "&Open";
			miFileMenu.MenuItems.Add(miOpen);
			miOpen.Shortcut = Shortcut.CtrlO;
			miOpen.Enabled=false;
		
			miSave=new MenuItem();
			miSave.Text = "&Save";
			miFileMenu.MenuItems.Add(miSave);
			miSave.Enabled=false;
		
			miExit=new MenuItem();
			miExit.Text = "E&xit";
			miExit.Click += new EventHandler(MMExitClick);
			miFileMenu.MenuItems.Add(miExit);
			
			miEditMenu = new MenuItem();
			miEditMenu.Text = "&Edit";
			mainmenu.MenuItems.Add(miEditMenu);
			
			miCut= new MenuItem();
			miCut.Text = "C&ut";
			miEditMenu.MenuItems.Add(miCut);
			miCut.Shortcut = Shortcut.CtrlX;
			miCut.Enabled=false;
			
			miCopy = new MenuItem();
			miCopy.Text = "&Copy";
			miEditMenu.MenuItems.Add(miCopy);
			miCopy.Shortcut = Shortcut.CtrlC;
			miCopy.Enabled=false;
			
			miPaste = new MenuItem();
			miPaste.Text = "&Paste";
			miEditMenu.MenuItems.Add(miPaste);
			miPaste.Shortcut = Shortcut.CtrlV;
			miCopy.Enabled=false;
			
			miHelpMenu = new MenuItem();
			miHelpMenu.Text = "&Help";
			mainmenu.MenuItems.Add(miHelpMenu);
			
			miAbout= new MenuItem();
			miAbout.Text = "&About";
			miHelpMenu.MenuItems.Add(miAbout);
			miAbout.Enabled=false;
			//miAbout.Shortcut = Shortcut.CtrlA;
		
		
			this.Menu = mainmenu;
			//
			// constructor code after the InitializeComponent() call.
			//
			
			//set all param TextBox references:
		}
		public void CloseSafe() {
			if (!bClosedSafe) {
				try {
					//TODO: stuff here
				}
				catch (Exception exn) {
					sStatus="Exception error in CloseSafe: "+exn.ToString();
				}
				bClosedSafe=true;
			}
		}
		void BtnBrowseClick(object sender, System.EventArgs e) {
			ofiledlgSource.FileName="";
			ofiledlgSource.ShowDialog();
		}
		
		void BtnGoClick(object sender, System.EventArgs e) {
			//if (sSource!="") {
			//}
			//else {
			//	sStatus="No source selected.";
			//}
		}
		void OfiledlgSourceFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
			if (ofiledlgSource.FileName!="") {
				this.tbSource.Text=ofiledlgSource.FileName;
			}
			else {
				sStatus="No file selected.";
			}
		}
		void TbFramesTextChanged(object sender, System.EventArgs e) {
			DistributeColonSeparatedNumbers();
		}
		void TbHHTextChanged(object sender, System.EventArgs e) {
			DistributeColonSeparatedNumbers();
		}
		void TbMMTextChanged(object sender, System.EventArgs e) {
			DistributeColonSeparatedNumbers();
		}
		void TbSSTextChanged(object sender, System.EventArgs e) {
			DistributeColonSeparatedNumbers();
		}
		void TbFFTextChanged(object sender, System.EventArgs e) {
			DistributeColonSeparatedNumbers();
		}
		void DistributeColonSeparatedNumbers() {
			int index=tbHH.Text.IndexOf(":");
			if (index>=0) {
				tbMM.Text=tbHH.Text.Substring(index+1, tbHH.Text.Length-(index+1));
				tbHH.Text=tbHH.Text.Substring(0,index);
			}
			index=tbMM.Text.IndexOf(":");
			if (index>=0) {
				tbSS.Text=tbMM.Text.Substring(index+1, tbMM.Text.Length-(index+1));
				tbMM.Text=tbMM.Text.Substring(0,index);
			}
			index=tbSS.Text.IndexOf(":");
			if (index>=0) {
				tbFF.Text=tbSS.Text.Substring(index+1, tbSS.Text.Length-(index+1));
				tbSS.Text=tbSS.Text.Substring(0,index);
			}
		}
		void UpdateCalcVars() {
			iCalcHH = (tbHH.Text!="")?Convert.ToInt32(tbHH.Text):0;
			iCalcMM = (tbMM.Text!="")?Convert.ToInt32(tbMM.Text):0;
			iCalcSS = (tbSS.Text!="")?Convert.ToInt32(tbSS.Text):0;
			iCalcFF = (tbFF.Text!="")?Convert.ToInt32(tbFF.Text):0;
			iCalcFrames = (tbFrames.Text!="")?Convert.ToInt32(tbFrames.Text):0;
			dCalcFrameRate = ((tbFrameRate.Text!="")?Convert.ToDecimal(tbFrameRate.Text):0M);
			//ValidateCalcVars();
		}
		void UpdateCalcDisplay() {
			tbHH.Text=iCalcHH.ToString();
			tbMM.Text=iCalcMM.ToString();
			tbSS.Text=iCalcSS.ToString();
			tbFF.Text=iCalcFF.ToString();
			tbFrames.Text=iCalcFrames.ToString();
		}
		void DoTimeFromFrames() {
			int iSeconds=(int)(((decimal)iCalcFrames)/dCalcFrameRate);
			iCalcFF=iCalcFrames-(int)(((decimal)iSeconds)*dCalcFrameRate);
			iCalcHH=iSeconds/(60*60);
			iSeconds-=iCalcHH*60*60;
			iCalcMM=iSeconds/60;
			iCalcSS=iSeconds-iCalcMM*60;
			UpdateCalcDisplay();
		}
		void DoFramesFromTime() {
			decimal dSeconds=(iCalcSS+iCalcMM*60+iCalcHH*60*60);
			iCalcFrames=iCalcFF+(int)(dSeconds*dCalcFrameRate);//OK to truncate (?)
			UpdateCalcDisplay();
		}
		void ValidateCalcVars() {
			bool bChanged=false;
			if (dCalcFrameRate<=0) {
				bChanged=true;
				dCalcFrameRate=1;
			}
			if (iCalcFrames<0) {
				bChanged=true;
				iCalcFrames=0;
			}
			if (iCalcHH<0) {
				bChanged=true;
				iCalcHH=0;
			}
			if (iCalcMM<0) {
				bChanged=true;
				iCalcMM=0;
			}
			if (iCalcSS<0) {
				bChanged=true;
				iCalcSS=0;
			}
			if (iCalcFF<0) {
				bChanged=true;
				iCalcFF=0;
			}
			if (bChanged) UpdateCalcDisplay();
		}
		
		void BtnRightClick(object sender, System.EventArgs e) {
			UpdateCalcVars();
			DoFramesFromTime();
		}
		
		void BtnLeftClick(object sender, System.EventArgs e) {
			UpdateCalcVars();
			DoTimeFromFrames();
		}
		
		void Btn23976Click(object sender, System.EventArgs e) {
			this.tbFrameRate.Text="23.976";
		}
		
		void Btn2997Click(object sender, System.EventArgs e)
		{
			this.tbFrameRate.Text="29.97";
		}
		
		void BtnFrom2997to23976Click(object sender, System.EventArgs e)
		{
			tbFrameRate.Text="29.97";
			UpdateCalcVars();
			DoFramesFromTime();
			tbFrameRate.Text="23.976";
			UpdateCalcVars();
			DoTimeFromFrames();
			DoLogTime();
		}
		void DoLogTime() {
			string sHH=tbHH.Text;
			if (sHH.Length<2) sHH="0"+sHH;
			string sMM=tbMM.Text;
			if (sMM.Length<2) sMM="0"+sMM;
			string sSS=tbSS.Text;
			if (sSS.Length<2) sSS="0"+sSS;
			string sFF=tbFF.Text;
			if (sFF.Length<2) sFF="0"+sFF;
			sLog+=sHH+":"+sMM+":"+sSS+":"+sFF+Environment.NewLine;
		}
		
		void BtnSaveLogClick(object sender, System.EventArgs e) {
			StringToFile("Oops, log not implemented", sLog);
		}
		
		public static void StringToFile(string sNow, string sFile) {
			try {
				StreamWriter srNow=new StreamWriter(sFile);
				srNow.Write(sNow);
				srNow.Close();
			}
			catch (Exception exn) {
				sStatus="Error saving \""+sFile+"\": "+exn.ToString();
			}
		}
		void MMExitClick(object sender, System.EventArgs e) {
			CloseSafe();
			Application.Exit();
		}
		//void MainFormActivated(object sender, System.EventArgs e) {
    	//	splashscreen.Close();
		//}
		//public static void DoSplash() {
		//	splashscreen = new SplashScreen();
		//	splashscreen.ShowDialog();
		//}
	}//end class MainForm
}//end namespace

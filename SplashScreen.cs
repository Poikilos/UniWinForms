
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace OrangejuiceElectronica {
	/// <summary>
	/// Summary description for SplashScreen.
	/// </summary>
	public class SplashScreen : System.Windows.Forms.Form {
		public static int MaxRefreshInterval=350;
		public static int MinRefreshInterval=100;
		private int iStartedTick=Environment.TickCount; //PUBLICLY, use SleepUntilMinDelay instead
		private bool bFirstMessage=true;
		
		private static int iLastIntervalTick=-1;
		private static int iMinTotalDelay=750;
		public static int MinDelay {
			get {
				return iMinTotalDelay;
			}
			set {
				iMinTotalDelay=value;
			}
		}
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label lblStatus;
		public string sStatus {
			set {
				if (value!=lblStatus.Text) {
					lblStatus.Text=value;
					RefreshIfMinRefreshIntervalReached();
				}
			}
			get {
				return lblStatus.Text;
			}
		}
		public bool SetStatus(string sMsg) {
			sStatus=sMsg;
			return true;
		}
		public void RefreshNow() {
			Application.DoEvents();
			iLastIntervalTick=Environment.TickCount;
			bFirstMessage=false;
		}
		public void RefreshNow(string sMsg) {
			lblStatus.Text=sMsg;
			Application.DoEvents();
			iLastIntervalTick=Environment.TickCount;
			bFirstMessage=false;
		}
		public void RefreshIfMinRefreshIntervalReached() {
			if (bFirstMessage || Environment.TickCount-iLastIntervalTick>MinRefreshInterval) {
				Application.DoEvents();
				iLastIntervalTick=Environment.TickCount;
				bFirstMessage=false;
			}
		}
		public void RefreshIfDifferent(string sMsg) {
			if (bFirstMessage || sMsg!=lblStatus.Text) RefreshNow(sMsg);
		}
		public SplashScreen() {
			string sVerb="initializing";
			try {
				InitializeComponent();
				sVerb="getting start time";
				iStartedTick=Environment.TickCount;
				sVerb="getting bitmap";
				Bitmap bmpNow = new Bitmap("image-splash.png");
				if (bmpNow!=null) {
					//bmpNow.MakeTransparent(bmpNow.GetPixel(1,1));
					sVerb="using bitmap as background";
					this.Width=bmpNow.Width;
					this.Height=bmpNow.Height;
					sVerb="using bitmap as background";
					this.BackgroundImage = bmpNow;
					sVerb="finishing";
				}
				bFirstMessage=true;
			}
			catch (Exception exn) {
				Console.Error.WriteLine("Error in SplashScreen constructor while "+sVerb+": ");
				Console.Error.WriteLine(exn.ToString());
				Console.Error.WriteLine();
			}
		}//end constructor
		public void SleepUntilMinDelay() {
			int iFakeMessageSpleeper=6;
			int iFakeMessages=(MinDelay-(Environment.TickCount-iStartedTick))/iFakeMessageSpleeper;
			for (int iX=0; iX<iFakeMessages; iX++) {
				//sStatus=sStatus;
				Application.DoEvents();
				Thread.Sleep(iFakeMessageSpleeper);
			}			
		}
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public void RefreshStatusIfWaitingTooLong() {
			if (Environment.TickCount-iLastIntervalTick>MaxRefreshInterval) RefreshNow();
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			//System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SplashScreen));
			this.lblStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//lblStatus
			//
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;//System.Drawing.Color.White;
			this.lblStatus.Location = new System.Drawing.Point(32, 400);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(640-64, 64);
			this.lblStatus.TabStop = false;
			this.lblStatus.Text = "Starting...";
			// 
			// SplashScreen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			//this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(640,480);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SplashScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashScreen";
			//this.TransparencyKey = System.Drawing.Color.Black;
			this.Controls.Add(this.lblStatus);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
	}//end SplashScreen
}//end namespace



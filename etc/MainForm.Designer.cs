/*
 *  Created by SharpDevelop (To change this template use Tools | Options | Coding | Edit Standard Headers).
 * User: Jake Gustafson (Owner)
 * Date: 9/22/2006
 * Time: 10:39 PM
 * 
 */
namespace OrangejuiceElectronica
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnBrowse = new System.Windows.Forms.Button();
			this.tbSource = new System.Windows.Forms.TextBox();
			this.tbParam1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbParam0 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ofiledlgSource = new System.Windows.Forms.OpenFileDialog();
			this.btnGo = new System.Windows.Forms.Button();
			this.tbParam2 = new System.Windows.Forms.TextBox();
			this.tbParam3 = new System.Windows.Forms.TextBox();
			this.lblParam2 = new System.Windows.Forms.Label();
			this.lblParam3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbFrameRate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbHH = new System.Windows.Forms.TextBox();
			this.tbMM = new System.Windows.Forms.TextBox();
			this.tbSS = new System.Windows.Forms.TextBox();
			this.tbFF = new System.Windows.Forms.TextBox();
			this.tbFrames = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.rbModeTranspose = new System.Windows.Forms.RadioButton();
			this.rbModeScroll = new System.Windows.Forms.RadioButton();
			this.btn23976 = new System.Windows.Forms.Button();
			this.btn2997 = new System.Windows.Forms.Button();
			this.btnFrom2997to23976 = new System.Windows.Forms.Button();
			this.btnSaveLog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(389, 37);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 21);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
			// 
			// tbSource
			// 
			this.tbSource.Location = new System.Drawing.Point(8, 37);
			this.tbSource.Name = "tbSource";
			this.tbSource.Size = new System.Drawing.Size(375, 21);
			this.tbSource.TabIndex = 1;
			// 
			// tbParam1
			// 
			this.tbParam1.Location = new System.Drawing.Point(21, 159);
			this.tbParam1.Name = "tbParam1";
			this.tbParam1.Size = new System.Drawing.Size(126, 21);
			this.tbParam1.TabIndex = 3;
			this.tbParam1.Text = "2";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(153, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(295, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Output sequence name - 0000.png etc will be added.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Source file";
			// 
			// tbParam0
			// 
			this.tbParam0.Location = new System.Drawing.Point(21, 132);
			this.tbParam0.Name = "tbParam0";
			this.tbParam0.Size = new System.Drawing.Size(126, 21);
			this.tbParam0.TabIndex = 6;
			this.tbParam0.Text = "NamesList";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(153, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Pixels per frame (text scroll speed)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ofiledlgSource
			// 
			this.ofiledlgSource.FileOk += new System.ComponentModel.CancelEventHandler(this.OfiledlgSourceFileOk);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(184, 81);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 9;
			this.btnGo.Text = "Go";
			this.btnGo.Click += new System.EventHandler(this.BtnGoClick);
			// 
			// tbParam2
			// 
			this.tbParam2.Location = new System.Drawing.Point(21, 186);
			this.tbParam2.Name = "tbParam2";
			this.tbParam2.Size = new System.Drawing.Size(126, 21);
			this.tbParam2.TabIndex = 10;
			this.tbParam2.Text = "640";
			// 
			// tbParam3
			// 
			this.tbParam3.Location = new System.Drawing.Point(21, 213);
			this.tbParam3.Name = "tbParam3";
			this.tbParam3.Size = new System.Drawing.Size(126, 21);
			this.tbParam3.TabIndex = 11;
			this.tbParam3.Text = "480";
			// 
			// lblParam2
			// 
			this.lblParam2.Location = new System.Drawing.Point(153, 186);
			this.lblParam2.Name = "lblParam2";
			this.lblParam2.Size = new System.Drawing.Size(295, 21);
			this.lblParam2.TabIndex = 12;
			this.lblParam2.Text = "Width for output frame";
			this.lblParam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblParam3
			// 
			this.lblParam3.Location = new System.Drawing.Point(153, 213);
			this.lblParam3.Name = "lblParam3";
			this.lblParam3.Size = new System.Drawing.Size(295, 21);
			this.lblParam3.TabIndex = 13;
			this.lblParam3.Text = "Height for output frame";
			this.lblParam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(480, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "Calculator:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tbFrameRate
			// 
			this.tbFrameRate.Location = new System.Drawing.Point(184, 296);
			this.tbFrameRate.Name = "tbFrameRate";
			this.tbFrameRate.Size = new System.Drawing.Size(104, 21);
			this.tbFrameRate.TabIndex = 15;
			this.tbFrameRate.Text = "23.976";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(184, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Frames Per Second";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// tbHH
			// 
			this.tbHH.Location = new System.Drawing.Point(24, 296);
			this.tbHH.Name = "tbHH";
			this.tbHH.Size = new System.Drawing.Size(24, 21);
			this.tbHH.TabIndex = 17;
			this.tbHH.TextChanged += new System.EventHandler(this.TbHHTextChanged);
			// 
			// tbMM
			// 
			this.tbMM.Location = new System.Drawing.Point(56, 296);
			this.tbMM.Name = "tbMM";
			this.tbMM.Size = new System.Drawing.Size(24, 21);
			this.tbMM.TabIndex = 18;
			this.tbMM.TextChanged += new System.EventHandler(this.TbMMTextChanged);
			// 
			// tbSS
			// 
			this.tbSS.Location = new System.Drawing.Point(88, 296);
			this.tbSS.Name = "tbSS";
			this.tbSS.Size = new System.Drawing.Size(24, 21);
			this.tbSS.TabIndex = 19;
			this.tbSS.TextChanged += new System.EventHandler(this.TbSSTextChanged);
			// 
			// tbFF
			// 
			this.tbFF.Location = new System.Drawing.Point(120, 296);
			this.tbFF.Name = "tbFF";
			this.tbFF.Size = new System.Drawing.Size(24, 21);
			this.tbFF.TabIndex = 20;
			this.tbFF.TextChanged += new System.EventHandler(this.TbFFTextChanged);
			// 
			// tbFrames
			// 
			this.tbFrames.Location = new System.Drawing.Point(328, 296);
			this.tbFrames.Name = "tbFrames";
			this.tbFrames.Size = new System.Drawing.Size(100, 21);
			this.tbFrames.TabIndex = 21;
			this.tbFrames.TextChanged += new System.EventHandler(this.TbFramesTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 272);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Hr:Min:Sec:Frames";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(328, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "Frames";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(200, 320);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(75, 23);
			this.btnRight.TabIndex = 24;
			this.btnRight.Text = ">>>>>";
			this.btnRight.Click += new System.EventHandler(this.BtnRightClick);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(200, 344);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(75, 23);
			this.btnLeft.TabIndex = 25;
			this.btnLeft.Text = "<<<<<";
			this.btnLeft.Click += new System.EventHandler(this.BtnLeftClick);
			// 
			// rbModeTranspose
			// 
			this.rbModeTranspose.Checked = true;
			this.rbModeTranspose.Location = new System.Drawing.Point(27, 78);
			this.rbModeTranspose.Name = "rbModeTranspose";
			this.rbModeTranspose.Size = new System.Drawing.Size(151, 24);
			this.rbModeTranspose.TabIndex = 26;
			this.rbModeTranspose.TabStop = true;
			this.rbModeTranspose.Text = "Transpose Image Squares";
			// 
			// rbModeScroll
			// 
			this.rbModeScroll.Location = new System.Drawing.Point(27, 102);
			this.rbModeScroll.Name = "rbModeScroll";
			this.rbModeScroll.Size = new System.Drawing.Size(104, 24);
			this.rbModeScroll.TabIndex = 27;
			this.rbModeScroll.Text = "Scroll Image";
			// 
			// btn23976
			// 
			this.btn23976.Location = new System.Drawing.Point(281, 344);
			this.btn23976.Name = "btn23976";
			this.btn23976.Size = new System.Drawing.Size(75, 23);
			this.btn23976.TabIndex = 28;
			this.btn23976.Text = "23.976";
			this.btn23976.Click += new System.EventHandler(this.Btn23976Click);
			// 
			// btn2997
			// 
			this.btn2997.Location = new System.Drawing.Point(281, 320);
			this.btn2997.Name = "btn2997";
			this.btn2997.Size = new System.Drawing.Size(75, 23);
			this.btn2997.TabIndex = 29;
			this.btn2997.Text = "29.97";
			this.btn2997.Click += new System.EventHandler(this.Btn2997Click);
			// 
			// btnFrom2997to23976
			// 
			this.btnFrom2997to23976.Location = new System.Drawing.Point(24, 320);
			this.btnFrom2997to23976.Name = "btnFrom2997to23976";
			this.btnFrom2997to23976.Size = new System.Drawing.Size(120, 23);
			this.btnFrom2997to23976.TabIndex = 30;
			this.btnFrom2997to23976.Text = "29.97 to 23.976";
			this.btnFrom2997to23976.Click += new System.EventHandler(this.BtnFrom2997to23976Click);
			// 
			// btnSaveLog
			// 
			this.btnSaveLog.Location = new System.Drawing.Point(24, 349);
			this.btnSaveLog.Name = "btnSaveLog";
			this.btnSaveLog.Size = new System.Drawing.Size(120, 23);
			this.btnSaveLog.TabIndex = 31;
			this.btnSaveLog.Text = "Save Log";
			this.btnSaveLog.Click += new System.EventHandler(this.BtnSaveLogClick);
			// 
			// MainForm
			// 
			//this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 415);
			this.Controls.Add(this.btnSaveLog);
			this.Controls.Add(this.btnFrom2997to23976);
			this.Controls.Add(this.btn2997);
			this.Controls.Add(this.btn23976);
			this.Controls.Add(this.rbModeScroll);
			this.Controls.Add(this.rbModeTranspose);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbFrames);
			this.Controls.Add(this.tbFF);
			this.Controls.Add(this.tbSS);
			this.Controls.Add(this.tbMM);
			this.Controls.Add(this.tbHH);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbFrameRate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblParam3);
			this.Controls.Add(this.lblParam2);
			this.Controls.Add(this.tbParam3);
			this.Controls.Add(this.tbParam2);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbParam0);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbParam1);
			this.Controls.Add(this.tbSource);
			//this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "UniWinForms alpha 2007-08-29";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSaveLog;
		private System.Windows.Forms.Button btnFrom2997to23976;
		private System.Windows.Forms.Button btn2997;
		private System.Windows.Forms.Button btn23976;
		private System.Windows.Forms.RadioButton rbModeScroll;
		private System.Windows.Forms.RadioButton rbModeTranspose;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbFrames;
		private System.Windows.Forms.TextBox tbFF;
		private System.Windows.Forms.TextBox tbSS;
		private System.Windows.Forms.TextBox tbMM;
		private System.Windows.Forms.TextBox tbHH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbFrameRate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblParam2;
		private System.Windows.Forms.Label lblParam3;
		private System.Windows.Forms.TextBox tbParam2;
		private System.Windows.Forms.TextBox tbParam3;
		private System.Windows.Forms.TextBox tbParam1;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox tbSource;
		private System.Windows.Forms.TextBox tbParam0;
		private System.Windows.Forms.OpenFileDialog ofiledlgSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBrowse;
	}
}

/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 8/30/2007
 * Time: 8:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem miClose;
		private System.Windows.Forms.MainMenu mainmenu;
		private System.Windows.Forms.SaveFileDialog sfiledlgNow;
		private System.Windows.Forms.MenuItem miFileMenu;
		private System.Windows.Forms.ToolBar toolbar;
		private System.Windows.Forms.MenuItem miExit;
		private System.Windows.Forms.MenuItem miSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem miFileSpacer1;
		private System.Windows.Forms.MenuItem miFileSpacer3;
		private System.Windows.Forms.MenuItem miFileSpacer2;
		private System.Windows.Forms.MenuItem miSelectAll;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.MenuItem miSelectNone;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button btnClosePrintPreview;
		private System.Windows.Forms.Splitter splitterLR;
		private System.Windows.Forms.Panel panelTL;
		private System.Windows.Forms.MenuItem miArrangeMenu;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.MenuItem miLooseDiagonal;
		private System.Windows.Forms.FolderBrowserDialog folderdlgNow;
		private System.Windows.Forms.MenuItem miOpen;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.OpenFileDialog ofiledlgNow;
		private System.Windows.Forms.ComboBox cbWindow;
		private System.Windows.Forms.MenuItem miRandomOffset;
		private System.Windows.Forms.MenuItem miRandomOffsetMore;
		private System.Windows.Forms.MenuItem miExport;
		private System.Windows.Forms.MenuItem miCopy;
		private System.Windows.Forms.MenuItem miTightDiagonal;
		private System.Windows.Forms.MenuItem miPrintPreview;
		private System.Windows.Forms.MenuItem miHelpMenu;
		private System.Windows.Forms.MenuItem miPaste;
		private System.Windows.Forms.PrintPreviewControl printpcontrolNow;
		private System.Windows.Forms.MenuItem miAbout;
		private System.Windows.Forms.MenuItem miRandomDistributeEvenly;
		private System.Windows.Forms.FontDialog fontdlgNow;
		private System.Windows.Forms.Splitter splitterUDBL;
		private System.Windows.Forms.MenuItem miSelectInverse;
		private System.Windows.Forms.MenuItem miDistributeEvenly;
		private System.Windows.Forms.MenuItem miContents;
		private System.Windows.Forms.MenuItem miClosestPossible;
		private System.Windows.Forms.MenuItem miSaveAs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuItem miPrint;
		private System.Windows.Forms.MenuItem miCut;
		private System.Windows.Forms.PrintDialog printdlgNow;
		private System.Windows.Forms.TextBox tbStatus;
		private System.Windows.Forms.MenuItem miNew;
		private System.Windows.Forms.MenuItem miEditSpacer1;
		private System.Windows.Forms.ColorDialog colordlgNow;
		private System.Windows.Forms.NumericUpDown nudSize;
		private System.Windows.Forms.MenuItem miAlignToGrid;
		private System.Windows.Forms.MenuItem miEditMenu;
		private System.Windows.Forms.MenuItem miImport;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// constructor code after the InitializeComponent() call.
			//
			//Thread th = new Thread(new ThreadStart(DoSplash));
			//th.ApartmentState = ApartmentState.STA;
			//th.IsBackground=true;
			//th.Start();
			splashscreen = new SplashScreen();
			splashscreen.Show();
			splashscreen.SleepUntilMinDelay();
			//Application.DoEvents();
			//Thread.Sleep(3000);
			//splashscreen.Close();
			//th.Abort();
			//Thread.Sleep(1000);
			
		}
		public static MainForm mainformNow=null;
		public static bool bChanges=true;//TODO: change to default false in actual program
		public static SplashScreen splashscreen=null;
		[STAThread]
		public static void Main(string[] args)
		{
			mainformNow=new MainForm();
			Application.Run(mainformNow);
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			this.miImport = new System.Windows.Forms.MenuItem();
			this.miEditMenu = new System.Windows.Forms.MenuItem();
			this.miAlignToGrid = new System.Windows.Forms.MenuItem();
			this.nudSize = new System.Windows.Forms.NumericUpDown();
			this.colordlgNow = new System.Windows.Forms.ColorDialog();
			this.miEditSpacer1 = new System.Windows.Forms.MenuItem();
			this.miNew = new System.Windows.Forms.MenuItem();
			this.tbStatus = new System.Windows.Forms.TextBox();
			this.printdlgNow = new System.Windows.Forms.PrintDialog();
			this.miCut = new System.Windows.Forms.MenuItem();
			this.miPrint = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.miSaveAs = new System.Windows.Forms.MenuItem();
			this.miClosestPossible = new System.Windows.Forms.MenuItem();
			this.miContents = new System.Windows.Forms.MenuItem();
			this.miDistributeEvenly = new System.Windows.Forms.MenuItem();
			this.miSelectInverse = new System.Windows.Forms.MenuItem();
			this.splitterUDBL = new System.Windows.Forms.Splitter();
			this.fontdlgNow = new System.Windows.Forms.FontDialog();
			this.miRandomDistributeEvenly = new System.Windows.Forms.MenuItem();
			this.miAbout = new System.Windows.Forms.MenuItem();
			this.printpcontrolNow = new System.Windows.Forms.PrintPreviewControl();
			this.miPaste = new System.Windows.Forms.MenuItem();
			this.miHelpMenu = new System.Windows.Forms.MenuItem();
			this.miPrintPreview = new System.Windows.Forms.MenuItem();
			this.miTightDiagonal = new System.Windows.Forms.MenuItem();
			this.miCopy = new System.Windows.Forms.MenuItem();
			this.miExport = new System.Windows.Forms.MenuItem();
			this.miRandomOffsetMore = new System.Windows.Forms.MenuItem();
			this.miRandomOffset = new System.Windows.Forms.MenuItem();
			this.cbWindow = new System.Windows.Forms.ComboBox();
			this.ofiledlgNow = new System.Windows.Forms.OpenFileDialog();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.miOpen = new System.Windows.Forms.MenuItem();
			this.folderdlgNow = new System.Windows.Forms.FolderBrowserDialog();
			this.miLooseDiagonal = new System.Windows.Forms.MenuItem();
			this.panelRight = new System.Windows.Forms.Panel();
			this.miArrangeMenu = new System.Windows.Forms.MenuItem();
			this.panelTL = new System.Windows.Forms.Panel();
			this.splitterLR = new System.Windows.Forms.Splitter();
			this.btnClosePrintPreview = new System.Windows.Forms.Button();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.miSelectNone = new System.Windows.Forms.MenuItem();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.miSelectAll = new System.Windows.Forms.MenuItem();
			this.miFileSpacer2 = new System.Windows.Forms.MenuItem();
			this.miFileSpacer3 = new System.Windows.Forms.MenuItem();
			this.miFileSpacer1 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.miSave = new System.Windows.Forms.MenuItem();
			this.miExit = new System.Windows.Forms.MenuItem();
			this.toolbar = new System.Windows.Forms.ToolBar();
			this.miFileMenu = new System.Windows.Forms.MenuItem();
			this.sfiledlgNow = new System.Windows.Forms.SaveFileDialog();
			this.mainmenu = new System.Windows.Forms.MainMenu();
			this.miClose = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
			this.panelLeft.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.panelTL.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// miImport
			// 
			this.miImport.Index = 6;
			this.miImport.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.miImport.Text = "&Import...";
			this.miImport.Click += new System.EventHandler(this.MiImportClick);
			// 
			// miEditMenu
			// 
			this.miEditMenu.Index = 1;
			this.miEditMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
						this.miCopy,
						this.miCut,
						this.miPaste,
						this.miEditSpacer1,
						this.miSelectAll,
						this.miSelectInverse,
						this.miSelectNone});
			this.miEditMenu.Text = "&Edit";
			// 
			// miAlignToGrid
			// 
			this.miAlignToGrid.Index = 0;
			this.miAlignToGrid.Text = "&Align to Grid";
			this.miAlignToGrid.Click += new System.EventHandler(this.MiAlignToGridClick);
			// 
			// nudSize
			// 
			this.nudSize.Increment = new System.Decimal(new int[] {
						64,
						0,
						0,
						0});
			this.nudSize.Location = new System.Drawing.Point(0, 234);
			this.nudSize.Maximum = new System.Decimal(new int[] {
						512,
						0,
						0,
						0});
			this.nudSize.Minimum = new System.Decimal(new int[] {
						64,
						0,
						0,
						0});
			this.nudSize.Name = "nudSize";
			this.nudSize.Size = new System.Drawing.Size(96, 20);
			this.nudSize.TabIndex = 7;
			this.nudSize.Value = new System.Decimal(new int[] {
						64,
						0,
						0,
						0});
			this.nudSize.ValueChanged += new System.EventHandler(this.NudSizeValueChanged);
			// 
			// miEditSpacer1
			// 
			this.miEditSpacer1.Index = 3;
			this.miEditSpacer1.Text = "-";
			// 
			// miNew
			// 
			this.miNew.Index = 0;
			this.miNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.miNew.Text = "&New";
			this.miNew.Click += new System.EventHandler(this.MiNewClick);
			// 
			// tbStatus
			// 
			this.tbStatus.BackColor = System.Drawing.SystemColors.Control;
			this.tbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbStatus.Location = new System.Drawing.Point(0, 417);
			this.tbStatus.Name = "tbStatus";
			this.tbStatus.Size = new System.Drawing.Size(536, 20);
			this.tbStatus.TabIndex = 6;
			this.tbStatus.Text = "Welcome to JustABox - And More!";
			// 
			// miCut
			// 
			this.miCut.Index = 1;
			this.miCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.miCut.Text = "C&ut";
			this.miCut.Click += new System.EventHandler(this.MiCutClick);
			// 
			// miPrint
			// 
			this.miPrint.Index = 9;
			this.miPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.miPrint.Text = "&Print";
			this.miPrint.Click += new System.EventHandler(this.MiPrintClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			// 
			// miSaveAs
			// 
			this.miSaveAs.Index = 3;
			this.miSaveAs.Text = "Save &As...";
			this.miSaveAs.Click += new System.EventHandler(this.MiSaveAsClick);
			// 
			// miClosestPossible
			// 
			this.miClosestPossible.Index = 6;
			this.miClosestPossible.Text = "&Closest Possible";
			this.miClosestPossible.Click += new System.EventHandler(this.MiClosestPossibleClick);
			// 
			// miContents
			// 
			this.miContents.Index = 1;
			this.miContents.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.miContents.Text = "&Contents";
			this.miContents.Click += new System.EventHandler(this.MiContentsClick);
			// 
			// miDistributeEvenly
			// 
			this.miDistributeEvenly.Index = 7;
			this.miDistributeEvenly.Text = "&Distribute Evenly";
			this.miDistributeEvenly.Click += new System.EventHandler(this.MiDistributeEvenlyClick);
			// 
			// miSelectInverse
			// 
			this.miSelectInverse.Index = 5;
			this.miSelectInverse.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
			this.miSelectInverse.Text = "Select &Inverse";
			this.miSelectInverse.Click += new System.EventHandler(this.MiSelectInverseClick);
			// 
			// splitterUDBL
			// 
			this.splitterUDBL.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitterUDBL.Location = new System.Drawing.Point(0, 0);
			this.splitterUDBL.MinExtra = 2;
			this.splitterUDBL.MinSize = 32;
			this.splitterUDBL.Name = "splitterUDBL";
			this.splitterUDBL.Size = new System.Drawing.Size(92, 3);
			this.splitterUDBL.TabIndex = 1;
			this.splitterUDBL.TabStop = false;
			this.splitterUDBL.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitterUDBLSplitterMoved);
			// 
			// miRandomDistributeEvenly
			// 
			this.miRandomDistributeEvenly.Index = 3;
			this.miRandomDistributeEvenly.Text = "&Random Distribute Evenly";
			this.miRandomDistributeEvenly.Click += new System.EventHandler(this.MiRandomDistributeEvenlyClick);
			// 
			// miAbout
			// 
			this.miAbout.Index = 0;
			this.miAbout.Text = "&About";
			this.miAbout.Click += new System.EventHandler(this.MiAboutClick);
			// 
			// printpcontrolNow
			// 
			this.printpcontrolNow.AutoZoom = false;
			this.printpcontrolNow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.printpcontrolNow.Location = new System.Drawing.Point(0, 0);
			this.printpcontrolNow.Name = "printpcontrolNow";
			this.printpcontrolNow.Size = new System.Drawing.Size(435, 371);
			this.printpcontrolNow.TabIndex = 0;
			this.printpcontrolNow.Visible = false;
			this.printpcontrolNow.Zoom = 0.3;
			// 
			// miPaste
			// 
			this.miPaste.Index = 2;
			this.miPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.miPaste.Text = "&Paste";
			this.miPaste.Click += new System.EventHandler(this.MiPasteClick);
			// 
			// miHelpMenu
			// 
			this.miHelpMenu.Index = 3;
			this.miHelpMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
						this.miAbout,
						this.miContents});
			this.miHelpMenu.Text = "&Help";
			// 
			// miPrintPreview
			// 
			this.miPrintPreview.Index = 10;
			this.miPrintPreview.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftP;
			this.miPrintPreview.Text = "&Print Preview";
			this.miPrintPreview.Click += new System.EventHandler(this.MiPrintPreviewClick);
			// 
			// miTightDiagonal
			// 
			this.miTightDiagonal.Index = 4;
			this.miTightDiagonal.Text = "&Tight Diagonal";
			this.miTightDiagonal.Click += new System.EventHandler(this.MiTightDiagonalClick);
			// 
			// miCopy
			// 
			this.miCopy.Index = 0;
			this.miCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.miCopy.Text = "&Copy";
			this.miCopy.Click += new System.EventHandler(this.MiCopyClick);
			// 
			// miExport
			// 
			this.miExport.Index = 7;
			this.miExport.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
			this.miExport.Text = "&Export...";
			this.miExport.Click += new System.EventHandler(this.MiExportClick);
			// 
			// miRandomOffsetMore
			// 
			this.miRandomOffsetMore.Index = 2;
			this.miRandomOffsetMore.Text = "&Random Offset More";
			this.miRandomOffsetMore.Click += new System.EventHandler(this.MiRandomOffsetMoreClick);
			// 
			// miRandomOffset
			// 
			this.miRandomOffset.Index = 1;
			this.miRandomOffset.Text = "&Random Offset";
			this.miRandomOffset.Click += new System.EventHandler(this.MiRandomOffsetClick);
			// 
			// cbWindow
			// 
			this.cbWindow.Items.AddRange(new object[] {
						"Window1",
						"Window2"});
			this.cbWindow.Location = new System.Drawing.Point(0, 254);
			this.cbWindow.Name = "cbWindow";
			this.cbWindow.Size = new System.Drawing.Size(96, 21);
			this.cbWindow.TabIndex = 5;
			this.cbWindow.Text = "comboBox1";
			this.cbWindow.SelectedIndexChanged += new System.EventHandler(this.CbWindowSelectedIndexChanged);
			// 
			// panelLeft
			// 
			this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelLeft.Controls.Add(this.panelTL);
			this.panelLeft.Controls.Add(this.splitterUDBL);
			this.panelLeft.Controls.Add(this.treeView1);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 42);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(96, 375);
			this.panelLeft.TabIndex = 8;
			// 
			// miOpen
			// 
			this.miOpen.Index = 1;
			this.miOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.miOpen.Text = "&Open...";
			this.miOpen.Click += new System.EventHandler(this.MiOpenClick);
			// 
			// miLooseDiagonal
			// 
			this.miLooseDiagonal.Index = 5;
			this.miLooseDiagonal.Text = "&Loose Diagonal";
			this.miLooseDiagonal.Click += new System.EventHandler(this.MiLooseDiagonalClick);
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.SystemColors.Control;
			this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelRight.Controls.Add(this.btnClosePrintPreview);
			this.panelRight.Controls.Add(this.printpcontrolNow);
			this.panelRight.DockPadding.Right = 1;
			this.panelRight.Location = new System.Drawing.Point(96, 42);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(440, 375);
			this.panelRight.TabIndex = 9;
			// 
			// miArrangeMenu
			// 
			this.miArrangeMenu.Index = 2;
			this.miArrangeMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
						this.miAlignToGrid,
						this.miRandomOffset,
						this.miRandomOffsetMore,
						this.miRandomDistributeEvenly,
						this.miTightDiagonal,
						this.miLooseDiagonal,
						this.miClosestPossible,
						this.miDistributeEvenly});
			this.miArrangeMenu.Text = "&Arrange";
			// 
			// panelTL
			// 
			this.panelTL.Controls.Add(this.nudSize);
			this.panelTL.Controls.Add(this.button1);
			this.panelTL.Controls.Add(this.cbWindow);
			this.panelTL.Controls.Add(this.groupBox1);
			this.panelTL.Controls.Add(this.radioButton2);
			this.panelTL.Controls.Add(this.radioButton1);
			this.panelTL.Controls.Add(this.checkBox2);
			this.panelTL.Controls.Add(this.checkBox1);
			this.panelTL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTL.Location = new System.Drawing.Point(0, 0);
			this.panelTL.Name = "panelTL";
			this.panelTL.Size = new System.Drawing.Size(92, 0);
			this.panelTL.TabIndex = 2;
			// 
			// splitterLR
			// 
			this.splitterLR.Location = new System.Drawing.Point(96, 42);
			this.splitterLR.Name = "splitterLR";
			this.splitterLR.Size = new System.Drawing.Size(4, 375);
			this.splitterLR.TabIndex = 10;
			this.splitterLR.TabStop = false;
			this.splitterLR.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitterLRSplitterMoved);
			// 
			// btnClosePrintPreview
			// 
			this.btnClosePrintPreview.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnClosePrintPreview.Location = new System.Drawing.Point(0, 0);
			this.btnClosePrintPreview.Name = "btnClosePrintPreview";
			this.btnClosePrintPreview.Size = new System.Drawing.Size(435, 23);
			this.btnClosePrintPreview.TabIndex = 1;
			this.btnClosePrintPreview.Text = "Close Print Preview";
			this.btnClosePrintPreview.Visible = false;
			this.btnClosePrintPreview.Click += new System.EventHandler(this.BtnClosePrintPreviewClick);
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(16, 48);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 1;
			this.radioButton4.Text = "radioButton4";
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(0, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(92, 368);
			this.treeView1.TabIndex = 0;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(8, 80);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 2;
			this.radioButton1.Text = "radioButton1";
			// 
			// miSelectNone
			// 
			this.miSelectNone.Index = 6;
			this.miSelectNone.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA;
			this.miSelectNone.Text = "Select &None";
			this.miSelectNone.Click += new System.EventHandler(this.MiSelectNoneClick);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 0;
			this.radioButton3.Text = "radioButton3";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(8, 104);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "radioButton2";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(8, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "checkBox2";
			// 
			// miSelectAll
			// 
			this.miSelectAll.Index = 4;
			this.miSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.miSelectAll.Text = "Select &All";
			this.miSelectAll.Click += new System.EventHandler(this.MiSelectAllClick);
			// 
			// miFileSpacer2
			// 
			this.miFileSpacer2.Index = 8;
			this.miFileSpacer2.Text = "-";
			// 
			// miFileSpacer3
			// 
			this.miFileSpacer3.Index = 11;
			this.miFileSpacer3.Text = "-";
			// 
			// miFileSpacer1
			// 
			this.miFileSpacer1.Index = 5;
			this.miFileSpacer1.Text = "-";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = -1;
			this.menuItem17.Text = "&Closest Possible";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Location = new System.Drawing.Point(8, 136);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(80, 88);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// miSave
			// 
			this.miSave.Index = 2;
			this.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.miSave.Text = "&Save";
			this.miSave.Click += new System.EventHandler(this.MiSaveClick);
			// 
			// miExit
			// 
			this.miExit.Index = 12;
			this.miExit.Text = "E&xit";
			this.miExit.Click += new System.EventHandler(this.MiExitClick);
			// 
			// toolbar
			// 
			this.toolbar.DropDownArrows = true;
			this.toolbar.Location = new System.Drawing.Point(0, 0);
			this.toolbar.Name = "toolbar";
			this.toolbar.ShowToolTips = true;
			this.toolbar.Size = new System.Drawing.Size(536, 42);
			this.toolbar.TabIndex = 7;
			// 
			// miFileMenu
			// 
			this.miFileMenu.Index = 0;
			this.miFileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
						this.miNew,
						this.miOpen,
						this.miSave,
						this.miSaveAs,
						this.miClose,
						this.miFileSpacer1,
						this.miImport,
						this.miExport,
						this.miFileSpacer2,
						this.miPrint,
						this.miPrintPreview,
						this.miFileSpacer3,
						this.miExit});
			this.miFileMenu.Text = "&File";
			// 
			// mainmenu
			// 
			this.mainmenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
						this.miFileMenu,
						this.miEditMenu,
						this.miArrangeMenu,
						this.miHelpMenu});
			// 
			// miClose
			// 
			this.miClose.Index = 4;
			this.miClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
			this.miClose.Text = "&Close";
			this.miClose.Click += new System.EventHandler(this.MiCloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 437);
			this.Controls.Add(this.splitterLR);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelLeft);
			this.Controls.Add(this.toolbar);
			this.Controls.Add(this.tbStatus);
			this.Menu = this.mainmenu;
			this.Name = "MainForm";
			this.Text = "JustABox - And More";
			this.InputLanguageChanging += new System.Windows.Forms.InputLanguageChangingEventHandler(this.MainFormInputLanguageChanging);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.EnabledChanged += new System.EventHandler(this.MainFormEnabledChanged);
			this.MaximizedBoundsChanged += new System.EventHandler(this.MainFormMaximizedBoundsChanged);
			this.Click += new System.EventHandler(this.MainFormClick);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainFormClosing);
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.MdiChildActivate += new System.EventHandler(this.MainFormMdiChildActivate);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainFormHelpRequested);
			this.DoubleClick += new System.EventHandler(this.MainFormDoubleClick);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
			this.DockChanged += new System.EventHandler(this.MainFormDockChanged);
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainFormLayout);
			this.ImeModeChanged += new System.EventHandler(this.MainFormImeModeChanged);
			this.MaximumSizeChanged += new System.EventHandler(this.MainFormMaximumSizeChanged);
			this.Validating += new System.ComponentModel.CancelEventHandler(this.MainFormValidating);
			this.FontChanged += new System.EventHandler(this.MainFormFontChanged);
			this.CausesValidationChanged += new System.EventHandler(this.MainFormCausesValidationChanged);
			this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainFormDragOver);
			this.ParentChanged += new System.EventHandler(this.MainFormParentChanged);
			this.Validated += new System.EventHandler(this.MainFormValidated);
			this.MouseHover += new System.EventHandler(this.MainFormMouseHover);
			this.Move += new System.EventHandler(this.MainFormMove);
			this.LocationChanged += new System.EventHandler(this.MainFormLocationChanged);
			this.BackColorChanged += new System.EventHandler(this.MainFormBackColorChanged);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
			this.Closed += new System.EventHandler(this.MainFormClosed);
			this.BindingContextChanged += new System.EventHandler(this.MainFormBindingContextChanged);
			this.StyleChanged += new System.EventHandler(this.MainFormStyleChanged);
			this.MinimumSizeChanged += new System.EventHandler(this.MainFormMinimumSizeChanged);
			this.VisibleChanged += new System.EventHandler(this.MainFormVisibleChanged);
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.MainFormInputLanguageChanged);
			this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.MainFormQueryAccessibilityHelp);
			this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.MainFormQueryContinueDrag);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.ForeColorChanged += new System.EventHandler(this.MainFormForeColorChanged);
			this.SystemColorsChanged += new System.EventHandler(this.MainFormSystemColorsChanged);
			this.RightToLeftChanged += new System.EventHandler(this.MainFormRightToLeftChanged);
			this.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.MainFormChangeUICues);
			this.MenuStart += new System.EventHandler(this.MainFormMenuStart);
			this.ContextMenuChanged += new System.EventHandler(this.MainFormContextMenuChanged);
			this.TabStopChanged += new System.EventHandler(this.MainFormTabStopChanged);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
			this.MouseEnter += new System.EventHandler(this.MainFormMouseEnter);
			this.Leave += new System.EventHandler(this.MainFormLeave);
			this.MouseLeave += new System.EventHandler(this.MainFormMouseLeave);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
			this.TextChanged += new System.EventHandler(this.MainFormTextChanged);
			this.CursorChanged += new System.EventHandler(this.MainFormCursorChanged);
			this.DragLeave += new System.EventHandler(this.MainFormDragLeave);
			this.MenuComplete += new System.EventHandler(this.MainFormMenuComplete);
			this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.MainFormGiveFeedback);
			this.Enter += new System.EventHandler(this.MainFormEnter);
			this.BackgroundImageChanged += new System.EventHandler(this.MainFormBackgroundImageChanged);
			this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
			((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
			this.panelLeft.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.panelTL.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
		void MainFormLoad(object sender, System.EventArgs e)
		{
			FixSizes();
		}
		
		void MainFormDragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			
		}
		
		void MainFormClick(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormDoubleClick(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
		
		void MainFormChangeUICues(object sender, System.Windows.Forms.UICuesEventArgs e)
		{
			
		}
		
		void MainFormClosed(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (bChanges) {
				DialogResult dlgresultNow=MessageBox.Show("Save Changes in all files before exiting?","Confirm Save", MessageBoxButtons.YesNoCancel);
				if (dlgresultNow==DialogResult.Yes) {
					MessageBox.Show("Not Yet Implemented");
		    	}
				else if (dlgresultNow==DialogResult.Cancel) {
					e.Cancel=true;
				}
			}
		}
		
		void MainFormHelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
		{
			
		}
		
		void MainFormImeModeChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormInputLanguageChanged(object sender, System.Windows.Forms.InputLanguageChangedEventArgs e)
		{
			
		}
		
		void MainFormInputLanguageChanging(object sender, System.Windows.Forms.InputLanguageChangingEventArgs e)
		{
			
		}
		
		void MainFormMenuComplete(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMenuStart(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormQueryAccessibilityHelp(object sender, System.Windows.Forms.QueryAccessibilityHelpEventArgs e)
		{
			
		}
		
		void MainFormStyleChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormSystemColorsChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormDragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			
		}
		
		void MainFormDragLeave(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormDragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			
		}
		
		void MainFormGiveFeedback(object sender, System.Windows.Forms.GiveFeedbackEventArgs e)
		{
			
		}
		
		void MainFormQueryContinueDrag(object sender, System.Windows.Forms.QueryContinueDragEventArgs e)
		{
			
		}
		
		void MainFormActivated(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormDeactivate(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormEnter(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormLeave(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormValidated(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		void MainFormKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
		}
		
		void MainFormKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
		}
		
		void MainFormKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
		}
		
		void MainFormLayout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			
		}
		
		void MainFormMdiChildActivate(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMove(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormResize(object sender, System.EventArgs e)
		{
			FixSizes();
		}
		
		void MainFormMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		}
		
		void MainFormMouseEnter(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMouseHover(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMouseLeave(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		}
		
		void MainFormMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		}
		
		void MainFormBackColorChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormBackgroundImageChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormBindingContextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormCausesValidationChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormContextMenuChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormCursorChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormDockChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormEnabledChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormFontChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormForeColorChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormLocationChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMaximizedBoundsChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMaximumSizeChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormMinimumSizeChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormParentChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormRightToLeftChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormSizeChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormTabStopChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormTextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormVisibleChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void RadioButton1CheckedChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MenuItem8Click(object sender, System.EventArgs e)
		{
			
		}
		
		void MenuItem2Click(object sender, System.EventArgs e)
		{
			
		}
		
		void MenuItem3Click(object sender, System.EventArgs e)
		{
			
		}
		
	
		void CbWindowSelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MiNewClick(object sender, System.EventArgs e)
		{
			
		}
		
		void MiOpenClick(object sender, System.EventArgs e)
		{
			ofiledlgNow.FileName="";
			ofiledlgNow.Title="Open";
			ofiledlgNow.Filter="Bitmap|*.bmp|All|*.*";
			ofiledlgNow.ShowDialog();			
		}
		
		void MiSaveClick(object sender, System.EventArgs e)
		{

		}
		
		void MiSaveAsClick(object sender, System.EventArgs e)
		{
			sfiledlgNow.FileName="";
			sfiledlgNow.Title="Save As";
			sfiledlgNow.ShowDialog();
		}
		
		void MiCloseClick(object sender, System.EventArgs e)
		{
			
		}
		
		void MiImportClick(object sender, System.EventArgs e)
		{
			ofiledlgNow.FileName="";
			ofiledlgNow.Title="Import";
			ofiledlgNow.Filter="Bitmap|*.bmp|All|*.*";
			ofiledlgNow.ShowDialog();			
		}
		
		void MiExportClick(object sender, System.EventArgs e)
		{
			sfiledlgNow.FileName="";
			sfiledlgNow.Title="Export";
			sfiledlgNow.ShowDialog();
		}
		
		void MiPrintClick(object sender, System.EventArgs e)
		{
			
			printdlgNow.ShowDialog();
			//printdlgNow.PrinterSettings
		}
		
		void MiPrintPreviewClick(object sender, System.EventArgs e)
		{
			btnClosePrintPreview.Visible=true;
			printpcontrolNow.Visible=true;
		}
		
		void BtnClosePrintPreviewClick(object sender, System.EventArgs e)
		{
			btnClosePrintPreview.Visible=false;
			printpcontrolNow.Visible=false;
		}
		
		void MiExitClick(object sender, System.EventArgs e)
		{
			mainformNow.Close();
		}
		
		void MiCopyClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiCutClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiPasteClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiSelectAllClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiSelectInverseClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiSelectNoneClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiAlignToGridClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiRandomOffsetClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiRandomOffsetMoreClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiRandomDistributeEvenlyClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiTightDiagonalClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiLooseDiagonalClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiClosestPossibleClick(object sender, System.EventArgs e)
		{
			 
		}
		
		void MiDistributeEvenlyClick(object sender, System.EventArgs e)
		{
			 
		}

		void MiAboutClick(object sender, System.EventArgs e)
		{
			MessageBox.Show("Created by:\n\nhttp://www.expertmultimedia.com");
		}
		
		void MiContentsClick(object sender, System.EventArgs e)
		{
			//TODO: open html help here
			MessageBox.Show("The only information available for this program is located at:\n\nhttp://www.expertmultimedia.com");
		}
		
		void NudSizeValueChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void SplitterUDBLSplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			
		}
		
		void SplitterLRSplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			FixSizes();
			//this.panelRight.Anchor.None;
			//this.panelRight.Dock=DockStyle.Right;
			//this.panelRight.DockPadding.Left=splitterLR.Width;
			//this.panelRight.Left=splitterLR.Left+splitterLR.Width;

		}
		public void FixSizes() {
			this.panelRight.Left=splitterLR.Left+splitterLR.Width;
			this.panelRight.Width=this.ClientRectangle.Width-panelRight.Left;
			this.panelRight.Height=this.ClientRectangle.Height-(this.toolbar.Height+this.tbStatus.Height);
		}
		//void MainFormActivated(object sender, System.EventArgs e) {
    	//	splashscreen.Close();
		//}
		//public static void DoSplash() {
		//	splashscreen = new SplashScreen();
		//	splashscreen.ShowDialog();
		//}
	}
}

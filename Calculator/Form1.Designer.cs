namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            editFormUserControl1 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            editFormUserControl3 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            lblNumberWriting = new DevExpress.XtraEditors.LabelControl();
            lblNumberReady = new DevExpress.XtraEditors.LabelControl();
            btnResult = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            btnSquareRoot = new DevExpress.XtraEditors.SimpleButton();
            btnSquare = new DevExpress.XtraEditors.SimpleButton();
            btnDivided = new DevExpress.XtraEditors.SimpleButton();
            btnNumberZero = new DevExpress.XtraEditors.SimpleButton();
            btnKomma = new DevExpress.XtraEditors.SimpleButton();
            btnSwitchNegativ = new DevExpress.XtraEditors.SimpleButton();
            btnTimes = new DevExpress.XtraEditors.SimpleButton();
            btnNumberNine = new DevExpress.XtraEditors.SimpleButton();
            btnNumberSix = new DevExpress.XtraEditors.SimpleButton();
            btnNumberThree = new DevExpress.XtraEditors.SimpleButton();
            btnMinus = new DevExpress.XtraEditors.SimpleButton();
            btnNumberEight = new DevExpress.XtraEditors.SimpleButton();
            btnNumberFive = new DevExpress.XtraEditors.SimpleButton();
            btnNumberTwo = new DevExpress.XtraEditors.SimpleButton();
            btnPlus = new DevExpress.XtraEditors.SimpleButton();
            btnNumberSeven = new DevExpress.XtraEditors.SimpleButton();
            btnNumberFour = new DevExpress.XtraEditors.SimpleButton();
            btnNumberOne = new DevExpress.XtraEditors.SimpleButton();
            lblResult = new DevExpress.XtraEditors.LabelControl();
            memoEditResults = new DevExpress.XtraEditors.MemoEdit();
            btnClearCalcHistorie = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)memoEditResults.Properties).BeginInit();
            SuspendLayout();
            // 
            // editFormUserControl1
            // 
            editFormUserControl1.Appearance.BackColor = Color.FromArgb(5, 75, 100);
            editFormUserControl1.Appearance.Options.UseBackColor = true;
            editFormUserControl3.SetBoundPropertyName(editFormUserControl1, "");
            editFormUserControl1.Location = new Point(-19, -5);
            editFormUserControl1.Name = "editFormUserControl1";
            editFormUserControl1.Size = new Size(757, 142);
            editFormUserControl1.TabIndex = 22;
            editFormUserControl1.TabStop = false;
            // 
            // editFormUserControl3
            // 
            editFormUserControl3.Appearance.BackColor = Color.FromArgb(5, 95, 115);
            editFormUserControl3.Appearance.ForeColor = Color.FromArgb(5, 75, 100);
            editFormUserControl3.Appearance.Options.UseBackColor = true;
            editFormUserControl3.Appearance.Options.UseForeColor = true;
            editFormUserControl1.SetBoundPropertyName(editFormUserControl3, "");
            editFormUserControl3.Location = new Point(-19, 122);
            editFormUserControl3.Name = "editFormUserControl3";
            editFormUserControl3.Size = new Size(757, 15);
            editFormUserControl3.TabIndex = 24;
            editFormUserControl3.TabStop = false;
            // 
            // lblNumberWriting
            // 
            lblNumberWriting.Appearance.BackColor = Color.FromArgb(5, 75, 100);
            lblNumberWriting.Appearance.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberWriting.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            lblNumberWriting.Appearance.Options.UseBackColor = true;
            lblNumberWriting.Appearance.Options.UseFont = true;
            lblNumberWriting.Appearance.Options.UseForeColor = true;
            editFormUserControl1.SetBoundPropertyName(lblNumberWriting, "");
            editFormUserControl3.SetBoundPropertyName(lblNumberWriting, "");
            lblNumberWriting.Location = new Point(3, 78);
            lblNumberWriting.Name = "lblNumberWriting";
            lblNumberWriting.Size = new Size(0, 38);
            lblNumberWriting.TabIndex = 25;
            // 
            // lblNumberReady
            // 
            lblNumberReady.Appearance.BackColor = Color.FromArgb(5, 75, 100);
            lblNumberReady.Appearance.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberReady.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            lblNumberReady.Appearance.Options.UseBackColor = true;
            lblNumberReady.Appearance.Options.UseFont = true;
            lblNumberReady.Appearance.Options.UseForeColor = true;
            editFormUserControl1.SetBoundPropertyName(lblNumberReady, "");
            editFormUserControl3.SetBoundPropertyName(lblNumberReady, "");
            lblNumberReady.Location = new Point(3, 12);
            lblNumberReady.Name = "lblNumberReady";
            lblNumberReady.Size = new Size(0, 38);
            lblNumberReady.TabIndex = 26;
            // 
            // btnResult
            // 
            btnResult.AllowFocus = false;
            btnResult.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.Appearance.ForeColor = Color.WhiteSmoke;
            btnResult.Appearance.Options.UseFont = true;
            btnResult.Appearance.Options.UseForeColor = true;
            btnResult.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_xtraLight;
            btnResult.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnResult, "");
            editFormUserControl1.SetBoundPropertyName(btnResult, "");
            btnResult.Location = new Point(374, 414);
            btnResult.Name = "btnResult";
            btnResult.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnResult.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnResult.Size = new Size(85, 85);
            btnResult.TabIndex = 31;
            btnResult.TabStop = false;
            btnResult.Text = "=";
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.AllowFocus = false;
            btnClear.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Appearance.ForeColor = Color.WhiteSmoke;
            btnClear.Appearance.Options.UseFont = true;
            btnClear.Appearance.Options.UseForeColor = true;
            btnClear.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnClear, "");
            editFormUserControl1.SetBoundPropertyName(btnClear, "");
            btnClear.Location = new Point(374, 323);
            btnClear.Name = "btnClear";
            btnClear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClear.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnClear.Size = new Size(85, 85);
            btnClear.TabIndex = 32;
            btnClear.TabStop = false;
            btnClear.Text = "C";
            btnClear.Click += bntClear_Click;
            btnClear.DoubleClick += btnClear_DoubleClick;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.AllowFocus = false;
            btnSquareRoot.Appearance.Font = new Font("Arial Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSquareRoot.Appearance.ForeColor = Color.WhiteSmoke;
            btnSquareRoot.Appearance.Options.UseFont = true;
            btnSquareRoot.Appearance.Options.UseForeColor = true;
            btnSquareRoot.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnSquareRoot.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnSquareRoot, "");
            editFormUserControl1.SetBoundPropertyName(btnSquareRoot, "");
            btnSquareRoot.Location = new Point(374, 232);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnSquareRoot.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnSquareRoot.Size = new Size(85, 85);
            btnSquareRoot.TabIndex = 33;
            btnSquareRoot.TabStop = false;
            btnSquareRoot.Text = "Square\r\nRoot";
            btnSquareRoot.Click += btnSquareRoot_Click;
            // 
            // btnSquare
            // 
            btnSquare.AllowFocus = false;
            btnSquare.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnSquare.Appearance.ForeColor = Color.WhiteSmoke;
            btnSquare.Appearance.Options.UseFont = true;
            btnSquare.Appearance.Options.UseForeColor = true;
            btnSquare.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnSquare.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnSquare, "");
            editFormUserControl1.SetBoundPropertyName(btnSquare, "");
            btnSquare.Location = new Point(374, 143);
            btnSquare.Name = "btnSquare";
            btnSquare.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnSquare.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnSquare.Size = new Size(85, 85);
            btnSquare.TabIndex = 34;
            btnSquare.TabStop = false;
            btnSquare.Text = "x²";
            btnSquare.Click += btnSquare_Click;
            // 
            // btnDivided
            // 
            btnDivided.AllowFocus = false;
            btnDivided.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivided.Appearance.ForeColor = Color.WhiteSmoke;
            btnDivided.Appearance.Options.UseFont = true;
            btnDivided.Appearance.Options.UseForeColor = true;
            btnDivided.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnDivided.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnDivided, "");
            editFormUserControl1.SetBoundPropertyName(btnDivided, "");
            btnDivided.Location = new Point(283, 143);
            btnDivided.Name = "btnDivided";
            btnDivided.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnDivided.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnDivided.Size = new Size(85, 85);
            btnDivided.TabIndex = 38;
            btnDivided.TabStop = false;
            btnDivided.Text = "/";
            btnDivided.Click += btnDivided_Click;
            // 
            // btnNumberZero
            // 
            btnNumberZero.AllowFocus = false;
            btnNumberZero.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberZero.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberZero.Appearance.Options.UseFont = true;
            btnNumberZero.Appearance.Options.UseForeColor = true;
            btnNumberZero.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberZero.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberZero, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberZero, "");
            btnNumberZero.Location = new Point(283, 232);
            btnNumberZero.Name = "btnNumberZero";
            btnNumberZero.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberZero.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberZero.Size = new Size(85, 85);
            btnNumberZero.TabIndex = 37;
            btnNumberZero.TabStop = false;
            btnNumberZero.Text = "0";
            btnNumberZero.Click += btnNumberZero_Click;
            // 
            // btnKomma
            // 
            btnKomma.AllowFocus = false;
            btnKomma.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnKomma.Appearance.ForeColor = Color.WhiteSmoke;
            btnKomma.Appearance.Options.UseFont = true;
            btnKomma.Appearance.Options.UseForeColor = true;
            btnKomma.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnKomma.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnKomma, "");
            editFormUserControl1.SetBoundPropertyName(btnKomma, "");
            btnKomma.Location = new Point(283, 323);
            btnKomma.Name = "btnKomma";
            btnKomma.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKomma.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnKomma.Size = new Size(85, 85);
            btnKomma.TabIndex = 36;
            btnKomma.TabStop = false;
            btnKomma.Text = ",";
            btnKomma.Click += btnKomma_Click;
            // 
            // btnSwitchNegativ
            // 
            btnSwitchNegativ.AllowFocus = false;
            btnSwitchNegativ.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnSwitchNegativ.Appearance.ForeColor = Color.WhiteSmoke;
            btnSwitchNegativ.Appearance.Options.UseFont = true;
            btnSwitchNegativ.Appearance.Options.UseForeColor = true;
            btnSwitchNegativ.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnSwitchNegativ.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnSwitchNegativ, "");
            editFormUserControl1.SetBoundPropertyName(btnSwitchNegativ, "");
            btnSwitchNegativ.Location = new Point(283, 414);
            btnSwitchNegativ.Name = "btnSwitchNegativ";
            btnSwitchNegativ.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnSwitchNegativ.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnSwitchNegativ.Size = new Size(85, 85);
            btnSwitchNegativ.TabIndex = 35;
            btnSwitchNegativ.TabStop = false;
            btnSwitchNegativ.Text = "-/+";
            btnSwitchNegativ.Click += btnSwitchNegativ_Click;
            // 
            // btnTimes
            // 
            btnTimes.AllowFocus = false;
            btnTimes.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimes.Appearance.ForeColor = Color.WhiteSmoke;
            btnTimes.Appearance.Options.UseFont = true;
            btnTimes.Appearance.Options.UseForeColor = true;
            btnTimes.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnTimes.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnTimes, "");
            editFormUserControl1.SetBoundPropertyName(btnTimes, "");
            btnTimes.Location = new Point(192, 143);
            btnTimes.Name = "btnTimes";
            btnTimes.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnTimes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnTimes.Size = new Size(85, 85);
            btnTimes.TabIndex = 42;
            btnTimes.TabStop = false;
            btnTimes.Text = "*";
            btnTimes.Click += btnTimes_Click;
            // 
            // btnNumberNine
            // 
            btnNumberNine.AllowFocus = false;
            btnNumberNine.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberNine.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberNine.Appearance.Options.UseFont = true;
            btnNumberNine.Appearance.Options.UseForeColor = true;
            btnNumberNine.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberNine.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberNine, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberNine, "");
            btnNumberNine.Location = new Point(192, 232);
            btnNumberNine.Name = "btnNumberNine";
            btnNumberNine.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberNine.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberNine.Size = new Size(85, 85);
            btnNumberNine.TabIndex = 41;
            btnNumberNine.TabStop = false;
            btnNumberNine.Text = "9";
            btnNumberNine.Click += btnNumberNine_Click;
            // 
            // btnNumberSix
            // 
            btnNumberSix.AllowFocus = false;
            btnNumberSix.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberSix.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberSix.Appearance.Options.UseFont = true;
            btnNumberSix.Appearance.Options.UseForeColor = true;
            btnNumberSix.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberSix.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberSix, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberSix, "");
            btnNumberSix.Location = new Point(192, 323);
            btnNumberSix.Name = "btnNumberSix";
            btnNumberSix.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberSix.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberSix.Size = new Size(85, 85);
            btnNumberSix.TabIndex = 40;
            btnNumberSix.TabStop = false;
            btnNumberSix.Text = "6";
            btnNumberSix.Click += btnNumberSix_Click;
            // 
            // btnNumberThree
            // 
            btnNumberThree.AllowFocus = false;
            btnNumberThree.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberThree.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberThree.Appearance.Options.UseFont = true;
            btnNumberThree.Appearance.Options.UseForeColor = true;
            btnNumberThree.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberThree.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberThree, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberThree, "");
            btnNumberThree.Location = new Point(192, 414);
            btnNumberThree.Name = "btnNumberThree";
            btnNumberThree.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberThree.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberThree.Size = new Size(85, 85);
            btnNumberThree.TabIndex = 39;
            btnNumberThree.TabStop = false;
            btnNumberThree.Text = "3";
            btnNumberThree.Click += btnNumberThree_Click;
            // 
            // btnMinus
            // 
            btnMinus.AllowFocus = false;
            btnMinus.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Appearance.ForeColor = Color.WhiteSmoke;
            btnMinus.Appearance.Options.UseFont = true;
            btnMinus.Appearance.Options.UseForeColor = true;
            btnMinus.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnMinus.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnMinus, "");
            editFormUserControl1.SetBoundPropertyName(btnMinus, "");
            btnMinus.Location = new Point(101, 143);
            btnMinus.Name = "btnMinus";
            btnMinus.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnMinus.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnMinus.Size = new Size(85, 85);
            btnMinus.TabIndex = 46;
            btnMinus.TabStop = false;
            btnMinus.Text = "-";
            btnMinus.Click += btnMinus_Click;
            // 
            // btnNumberEight
            // 
            btnNumberEight.AllowFocus = false;
            btnNumberEight.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberEight.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberEight.Appearance.Options.UseFont = true;
            btnNumberEight.Appearance.Options.UseForeColor = true;
            btnNumberEight.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberEight.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberEight, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberEight, "");
            btnNumberEight.Location = new Point(101, 232);
            btnNumberEight.Name = "btnNumberEight";
            btnNumberEight.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberEight.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberEight.Size = new Size(85, 85);
            btnNumberEight.TabIndex = 45;
            btnNumberEight.TabStop = false;
            btnNumberEight.Text = "8";
            btnNumberEight.Click += btnNumberEight_Click;
            // 
            // btnNumberFive
            // 
            btnNumberFive.AllowFocus = false;
            btnNumberFive.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberFive.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberFive.Appearance.Options.UseFont = true;
            btnNumberFive.Appearance.Options.UseForeColor = true;
            btnNumberFive.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberFive.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberFive, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberFive, "");
            btnNumberFive.Location = new Point(101, 323);
            btnNumberFive.Name = "btnNumberFive";
            btnNumberFive.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberFive.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberFive.Size = new Size(85, 85);
            btnNumberFive.TabIndex = 44;
            btnNumberFive.TabStop = false;
            btnNumberFive.Text = "5";
            btnNumberFive.Click += btnNumberFive_Click;
            // 
            // btnNumberTwo
            // 
            btnNumberTwo.AllowFocus = false;
            btnNumberTwo.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberTwo.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberTwo.Appearance.Options.UseFont = true;
            btnNumberTwo.Appearance.Options.UseForeColor = true;
            btnNumberTwo.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberTwo.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberTwo, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberTwo, "");
            btnNumberTwo.Location = new Point(101, 414);
            btnNumberTwo.Name = "btnNumberTwo";
            btnNumberTwo.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberTwo.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberTwo.Size = new Size(85, 85);
            btnNumberTwo.TabIndex = 43;
            btnNumberTwo.TabStop = false;
            btnNumberTwo.Text = "2";
            btnNumberTwo.Click += btnNumberTwo_Click;
            // 
            // btnPlus
            // 
            btnPlus.AllowFocus = false;
            btnPlus.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Appearance.ForeColor = Color.WhiteSmoke;
            btnPlus.Appearance.Options.UseFont = true;
            btnPlus.Appearance.Options.UseForeColor = true;
            btnPlus.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_baby;
            btnPlus.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnPlus, "");
            editFormUserControl1.SetBoundPropertyName(btnPlus, "");
            btnPlus.Location = new Point(10, 143);
            btnPlus.Name = "btnPlus";
            btnPlus.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPlus.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnPlus.Size = new Size(85, 85);
            btnPlus.TabIndex = 50;
            btnPlus.TabStop = false;
            btnPlus.Text = "+";
            btnPlus.Click += btnPlus_Click;
            // 
            // btnNumberSeven
            // 
            btnNumberSeven.AllowFocus = false;
            btnNumberSeven.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberSeven.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberSeven.Appearance.Options.UseFont = true;
            btnNumberSeven.Appearance.Options.UseForeColor = true;
            btnNumberSeven.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberSeven.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberSeven, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberSeven, "");
            btnNumberSeven.Location = new Point(10, 232);
            btnNumberSeven.Name = "btnNumberSeven";
            btnNumberSeven.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberSeven.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberSeven.Size = new Size(85, 85);
            btnNumberSeven.TabIndex = 49;
            btnNumberSeven.TabStop = false;
            btnNumberSeven.Text = "7";
            btnNumberSeven.Click += btnNumberSeven_Click;
            // 
            // btnNumberFour
            // 
            btnNumberFour.AllowFocus = false;
            btnNumberFour.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberFour.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberFour.Appearance.Options.UseFont = true;
            btnNumberFour.Appearance.Options.UseForeColor = true;
            btnNumberFour.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberFour.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberFour, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberFour, "");
            btnNumberFour.Location = new Point(10, 323);
            btnNumberFour.Name = "btnNumberFour";
            btnNumberFour.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberFour.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberFour.Size = new Size(85, 85);
            btnNumberFour.TabIndex = 48;
            btnNumberFour.TabStop = false;
            btnNumberFour.Text = "4";
            btnNumberFour.Click += btnNumberFour_Click;
            // 
            // btnNumberOne
            // 
            btnNumberOne.AllowFocus = false;
            btnNumberOne.Appearance.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumberOne.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            btnNumberOne.Appearance.Options.UseFont = true;
            btnNumberOne.Appearance.Options.UseForeColor = true;
            btnNumberOne.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons;
            btnNumberOne.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnNumberOne, "");
            editFormUserControl1.SetBoundPropertyName(btnNumberOne, "");
            btnNumberOne.Location = new Point(10, 414);
            btnNumberOne.Name = "btnNumberOne";
            btnNumberOne.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNumberOne.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnNumberOne.Size = new Size(85, 85);
            btnNumberOne.TabIndex = 47;
            btnNumberOne.TabStop = false;
            btnNumberOne.Text = "1";
            btnNumberOne.Click += btnNumberOne_Click;
            // 
            // lblResult
            // 
            lblResult.Appearance.BackColor = Color.FromArgb(5, 75, 100);
            lblResult.Appearance.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            lblResult.Appearance.Options.UseBackColor = true;
            lblResult.Appearance.Options.UseFont = true;
            lblResult.Appearance.Options.UseForeColor = true;
            editFormUserControl1.SetBoundPropertyName(lblResult, "");
            editFormUserControl3.SetBoundPropertyName(lblResult, "");
            lblResult.Location = new Point(10, 78);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 38);
            lblResult.TabIndex = 51;
            // 
            // memoEditResults
            // 
            editFormUserControl3.SetBoundPropertyName(memoEditResults, "");
            editFormUserControl1.SetBoundPropertyName(memoEditResults, "");
            memoEditResults.Location = new Point(465, 143);
            memoEditResults.Name = "memoEditResults";
            memoEditResults.Properties.Appearance.BackColor = Color.FromArgb(5, 75, 100);
            memoEditResults.Properties.Appearance.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memoEditResults.Properties.Appearance.ForeColor = Color.FromArgb(70, 200, 255);
            memoEditResults.Properties.Appearance.Options.UseBackColor = true;
            memoEditResults.Properties.Appearance.Options.UseFont = true;
            memoEditResults.Properties.Appearance.Options.UseForeColor = true;
            memoEditResults.Properties.ReadOnly = true;
            memoEditResults.Size = new Size(241, 314);
            memoEditResults.TabIndex = 52;
            // 
            // btnClearCalcHistorie
            // 
            btnClearCalcHistorie.AllowFocus = false;
            btnClearCalcHistorie.Appearance.Font = new Font("Arial Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearCalcHistorie.Appearance.ForeColor = Color.WhiteSmoke;
            btnClearCalcHistorie.Appearance.Options.UseFont = true;
            btnClearCalcHistorie.Appearance.Options.UseForeColor = true;
            btnClearCalcHistorie.BackgroundImage = Calculator.Properties.Resources.BackgroundImageButtons_light;
            btnClearCalcHistorie.BackgroundImageLayout = ImageLayout.Stretch;
            editFormUserControl3.SetBoundPropertyName(btnClearCalcHistorie, "");
            editFormUserControl1.SetBoundPropertyName(btnClearCalcHistorie, "");
            btnClearCalcHistorie.Location = new Point(465, 463);
            btnClearCalcHistorie.Name = "btnClearCalcHistorie";
            btnClearCalcHistorie.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClearCalcHistorie.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnClearCalcHistorie.Size = new Size(241, 36);
            btnClearCalcHistorie.TabIndex = 53;
            btnClearCalcHistorie.TabStop = false;
            btnClearCalcHistorie.Text = "Verlauf löschen";
            btnClearCalcHistorie.Click += btnClearCalcHistorie_Click;
            // 
            // Form1
            // 
            Appearance.BackColor = Color.FromArgb(5, 95, 115);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editFormUserControl3.SetBoundPropertyName(this, "");
            editFormUserControl1.SetBoundPropertyName(this, "");
            ClientSize = new Size(718, 511);
            Controls.Add(btnClearCalcHistorie);
            Controls.Add(memoEditResults);
            Controls.Add(lblResult);
            Controls.Add(btnPlus);
            Controls.Add(btnNumberSeven);
            Controls.Add(btnNumberFour);
            Controls.Add(btnNumberOne);
            Controls.Add(btnMinus);
            Controls.Add(btnNumberEight);
            Controls.Add(btnNumberFive);
            Controls.Add(btnNumberTwo);
            Controls.Add(btnTimes);
            Controls.Add(btnNumberNine);
            Controls.Add(btnNumberSix);
            Controls.Add(btnNumberThree);
            Controls.Add(btnDivided);
            Controls.Add(btnNumberZero);
            Controls.Add(btnKomma);
            Controls.Add(btnSwitchNegativ);
            Controls.Add(btnSquare);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(lblNumberReady);
            Controls.Add(lblNumberWriting);
            Controls.Add(editFormUserControl3);
            Controls.Add(editFormUserControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            IconOptions.Image = (Image)resources.GetObject("Form1.IconOptions.Image");
            Name = "Form1";
            Text = "Taschenrechner L.I.T.";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)memoEditResults.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl1;
        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl3;
        private DevExpress.XtraEditors.LabelControl lblNumberWriting;
        private DevExpress.XtraEditors.LabelControl lblNumberReady;
        private DevExpress.XtraEditors.SimpleButton btnResult;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSquareRoot;
        private DevExpress.XtraEditors.SimpleButton btnSquare;
        private DevExpress.XtraEditors.SimpleButton btnDivided;
        private DevExpress.XtraEditors.SimpleButton btnNumberZero;
        private DevExpress.XtraEditors.SimpleButton btnKomma;
        private DevExpress.XtraEditors.SimpleButton btnSwitchNegativ;
        private DevExpress.XtraEditors.SimpleButton btnTimes;
        private DevExpress.XtraEditors.SimpleButton btnNumberNine;
        private DevExpress.XtraEditors.SimpleButton btnNumberSix;
        private DevExpress.XtraEditors.SimpleButton btnNumberThree;
        private DevExpress.XtraEditors.SimpleButton btnMinus;
        private DevExpress.XtraEditors.SimpleButton btnNumberEight;
        private DevExpress.XtraEditors.SimpleButton btnNumberFive;
        private DevExpress.XtraEditors.SimpleButton btnNumberTwo;
        private DevExpress.XtraEditors.SimpleButton btnPlus;
        private DevExpress.XtraEditors.SimpleButton btnNumberSeven;
        private DevExpress.XtraEditors.SimpleButton btnNumberFour;
        private DevExpress.XtraEditors.SimpleButton btnNumberOne;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.MemoEdit memoEditResults;
        private DevExpress.XtraEditors.SimpleButton btnClearCalcHistorie;
    }
}
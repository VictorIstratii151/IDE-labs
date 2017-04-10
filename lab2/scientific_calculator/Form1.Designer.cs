namespace scientific_calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnDec;
            this.bckSpaceBtn = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.PlusMinusbtn = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnPow2 = new System.Windows.Forms.Button();
            this.btn1overX = new System.Windows.Forms.Button();
            this.btnPow3 = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.ExpBtn = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.CEbtn = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnDec = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDec
            // 
            btnDec.Location = new System.Drawing.Point(385, 127);
            btnDec.Name = "btnDec";
            btnDec.Size = new System.Drawing.Size(53, 51);
            btnDec.TabIndex = 9;
            btnDec.Text = "Dec";
            btnDec.Click += new System.EventHandler(this.ConvertOperation);
            // 
            // bckSpaceBtn
            // 
            this.bckSpaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bckSpaceBtn.Location = new System.Drawing.Point(12, 70);
            this.bckSpaceBtn.Name = "bckSpaceBtn";
            this.bckSpaceBtn.Size = new System.Drawing.Size(53, 51);
            this.bckSpaceBtn.TabIndex = 2;
            this.bckSpaceBtn.Text = "◄";
            this.bckSpaceBtn.UseVisualStyleBackColor = true;
            this.bckSpaceBtn.Click += new System.EventHandler(this.bckSpcBtn);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.C.Location = new System.Drawing.Point(130, 70);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(53, 51);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.btnC);
            // 
            // PlusMinusbtn
            // 
            this.PlusMinusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PlusMinusbtn.Location = new System.Drawing.Point(189, 70);
            this.PlusMinusbtn.Name = "PlusMinusbtn";
            this.PlusMinusbtn.Size = new System.Drawing.Size(53, 51);
            this.PlusMinusbtn.TabIndex = 2;
            this.PlusMinusbtn.Text = "±";
            this.PlusMinusbtn.UseVisualStyleBackColor = true;
            this.PlusMinusbtn.Click += new System.EventHandler(this.btnPlusMinus);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn7.Location = new System.Drawing.Point(12, 127);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 51);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn8.Location = new System.Drawing.Point(71, 127);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 51);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn9.Location = new System.Drawing.Point(130, 127);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 51);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPlus.Location = new System.Drawing.Point(189, 127);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 51);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.ArithmeticOperation);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn4.Location = new System.Drawing.Point(12, 186);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 51);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn5.Location = new System.Drawing.Point(71, 186);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 51);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1.Location = new System.Drawing.Point(12, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 51);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn2.Location = new System.Drawing.Point(71, 243);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 51);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn6.Location = new System.Drawing.Point(130, 186);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 51);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn3.Location = new System.Drawing.Point(130, 243);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 51);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMinus.Location = new System.Drawing.Point(189, 186);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 51);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.ArithmeticOperation);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMul.Location = new System.Drawing.Point(189, 243);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(53, 51);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.ArithmeticOperation);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPi.Location = new System.Drawing.Point(267, 70);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(53, 51);
            this.btnPi.TabIndex = 2;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLog.Location = new System.Drawing.Point(326, 70);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(53, 51);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCosh.Location = new System.Drawing.Point(267, 186);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(53, 51);
            this.btnCosh.TabIndex = 2;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.TrigonOperation);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSinh.Location = new System.Drawing.Point(267, 127);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(53, 51);
            this.btnSinh.TabIndex = 2;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.TrigonOperation);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCos.Location = new System.Drawing.Point(326, 186);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(53, 51);
            this.btnCos.TabIndex = 2;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.TrigonOperation);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSin.Location = new System.Drawing.Point(326, 127);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(53, 51);
            this.btnSin.TabIndex = 2;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.TrigonOperation);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTanh.Location = new System.Drawing.Point(267, 243);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(53, 51);
            this.btnTanh.TabIndex = 2;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.TrigonOperation);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTan.Location = new System.Drawing.Point(326, 243);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(53, 51);
            this.btnTan.TabIndex = 2;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.TrigonOperation);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSqrt.Location = new System.Drawing.Point(385, 70);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(53, 51);
            this.btnSqrt.TabIndex = 2;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBin.Location = new System.Drawing.Point(385, 186);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(53, 51);
            this.btnBin.TabIndex = 2;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.ConvertOperation);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHex.Location = new System.Drawing.Point(385, 243);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(53, 51);
            this.btnHex.TabIndex = 2;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.ConvertOperation);
            // 
            // btnPow2
            // 
            this.btnPow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPow2.Location = new System.Drawing.Point(444, 70);
            this.btnPow2.Name = "btnPow2";
            this.btnPow2.Size = new System.Drawing.Size(53, 51);
            this.btnPow2.TabIndex = 2;
            this.btnPow2.Text = "x^2";
            this.btnPow2.UseVisualStyleBackColor = true;
            this.btnPow2.Click += new System.EventHandler(this.btnPow2_Click);
            // 
            // btn1overX
            // 
            this.btn1overX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1overX.Location = new System.Drawing.Point(444, 186);
            this.btn1overX.Name = "btn1overX";
            this.btn1overX.Size = new System.Drawing.Size(53, 51);
            this.btn1overX.TabIndex = 2;
            this.btn1overX.Text = "1/x";
            this.btn1overX.UseVisualStyleBackColor = true;
            this.btn1overX.Click += new System.EventHandler(this.btn1overX_Click);
            // 
            // btnPow3
            // 
            this.btnPow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPow3.Location = new System.Drawing.Point(444, 127);
            this.btnPow3.Name = "btnPow3";
            this.btnPow3.Size = new System.Drawing.Size(53, 51);
            this.btnPow3.TabIndex = 2;
            this.btnPow3.Text = "x^3";
            this.btnPow3.UseVisualStyleBackColor = true;
            this.btnPow3.Click += new System.EventHandler(this.btnPow3_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLn.Location = new System.Drawing.Point(444, 243);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(53, 51);
            this.btnLn.TabIndex = 2;
            this.btnLn.Text = "ln x";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn0.Location = new System.Drawing.Point(12, 300);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 51);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.buttonClick);
            // 
            // ExpBtn
            // 
            this.ExpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExpBtn.Location = new System.Drawing.Point(267, 300);
            this.ExpBtn.Name = "ExpBtn";
            this.ExpBtn.Size = new System.Drawing.Size(53, 51);
            this.ExpBtn.TabIndex = 2;
            this.ExpBtn.Text = "Exp";
            this.ExpBtn.UseVisualStyleBackColor = true;
            this.ExpBtn.Click += new System.EventHandler(this.btnExp);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDot.Location = new System.Drawing.Point(71, 300);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(53, 51);
            this.btnDot.TabIndex = 2;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEqual.Location = new System.Drawing.Point(130, 300);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(53, 51);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.button37_Click);
            // 
            // btnOct
            // 
            this.btnOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOct.Location = new System.Drawing.Point(385, 300);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(53, 51);
            this.btnOct.TabIndex = 2;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.ConvertOperation);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDiv.Location = new System.Drawing.Point(189, 300);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(53, 51);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.ArithmeticOperation);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMod.Location = new System.Drawing.Point(444, 300);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(53, 51);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.ArithmeticOperation);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 27);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(230, 37);
            this.txtDisplay.TabIndex = 3;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(23, 30);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 13);
            this.lblShow.TabIndex = 5;
            // 
            // CEbtn
            // 
            this.CEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CEbtn.Location = new System.Drawing.Point(71, 70);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(53, 51);
            this.CEbtn.TabIndex = 7;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = true;
            this.CEbtn.Click += new System.EventHandler(this.btnCE);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPow.Location = new System.Drawing.Point(326, 300);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(53, 51);
            this.btnPow.TabIndex = 8;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.ArithmeticOperation);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 370);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.CEbtn);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnPow3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn1overX);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPow2);
            this.Controls.Add(this.PlusMinusbtn);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(btnDec);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.C);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.ExpBtn);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.bckSpaceBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bckSpaceBtn;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button PlusMinusbtn;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnPow2;
        private System.Windows.Forms.Button btn1overX;
        private System.Windows.Forms.Button btnPow3;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button ExpBtn;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
    }
}


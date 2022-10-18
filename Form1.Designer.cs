namespace Lab_03_BV
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
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.txtResH = new System.Windows.Forms.TextBox();
            this.txtResS = new System.Windows.Forms.TextBox();
            this.txtResV = new System.Windows.Forms.TextBox();
            this.labelVB = new System.Windows.Forms.Label();
            this.labelSG = new System.Windows.Forms.Label();
            this.labelHR = new System.Windows.Forms.Label();
            this.bnSolve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorShowerStart = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorShowerRes = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorShowerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorShowerRes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtH
            // 
            this.txtH.AcceptsReturn = true;
            this.txtH.Location = new System.Drawing.Point(12, 12);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 23);
            this.txtH.TabIndex = 0;
            this.txtH.TextChanged += new System.EventHandler(this.txtH_TextChanged);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(12, 41);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 23);
            this.txtS.TabIndex = 1;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(12, 70);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(100, 23);
            this.txtV.TabIndex = 2;
            this.txtV.TextChanged += new System.EventHandler(this.txtV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "H [0..360]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "S [0..100]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "V [0..100]";
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbOperation.Location = new System.Drawing.Point(188, 33);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOperation.Size = new System.Drawing.Size(37, 23);
            this.cmbOperation.TabIndex = 6;
            this.cmbOperation.TabStop = false;
            this.cmbOperation.Text = "+";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(231, 33);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 23);
            this.txtTerm.TabIndex = 7;
            this.txtTerm.TextChanged += new System.EventHandler(this.txtTerm_TextChanged);
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Items.AddRange(new object[] {
            "R",
            "G",
            "B",
            "S",
            "V"});
            this.cmbTypes.Location = new System.Drawing.Point(337, 33);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(34, 23);
            this.cmbTypes.TabIndex = 8;
            this.cmbTypes.TabStop = false;
            this.cmbTypes.Text = "R";
            // 
            // txtResH
            // 
            this.txtResH.Enabled = false;
            this.txtResH.Location = new System.Drawing.Point(388, 12);
            this.txtResH.Name = "txtResH";
            this.txtResH.Size = new System.Drawing.Size(100, 23);
            this.txtResH.TabIndex = 9;
            // 
            // txtResS
            // 
            this.txtResS.Enabled = false;
            this.txtResS.Location = new System.Drawing.Point(388, 44);
            this.txtResS.Name = "txtResS";
            this.txtResS.Size = new System.Drawing.Size(100, 23);
            this.txtResS.TabIndex = 10;
            // 
            // txtResV
            // 
            this.txtResV.Enabled = false;
            this.txtResV.Location = new System.Drawing.Point(388, 73);
            this.txtResV.Name = "txtResV";
            this.txtResV.Size = new System.Drawing.Size(100, 23);
            this.txtResV.TabIndex = 11;
            // 
            // labelVB
            // 
            this.labelVB.AutoSize = true;
            this.labelVB.Location = new System.Drawing.Point(497, 76);
            this.labelVB.Name = "labelVB";
            this.labelVB.Size = new System.Drawing.Size(55, 15);
            this.labelVB.TabIndex = 14;
            this.labelVB.Text = "V [0..100]";
            // 
            // labelSG
            // 
            this.labelSG.AutoSize = true;
            this.labelSG.Location = new System.Drawing.Point(497, 47);
            this.labelSG.Name = "labelSG";
            this.labelSG.Size = new System.Drawing.Size(54, 15);
            this.labelSG.TabIndex = 13;
            this.labelSG.Text = "S [0..100]";
            // 
            // labelHR
            // 
            this.labelHR.AutoSize = true;
            this.labelHR.Location = new System.Drawing.Point(494, 15);
            this.labelHR.Name = "labelHR";
            this.labelHR.Size = new System.Drawing.Size(57, 15);
            this.labelHR.TabIndex = 12;
            this.labelHR.Text = "H [0..360]";
            // 
            // bnSolve
            // 
            this.bnSolve.Location = new System.Drawing.Point(188, 65);
            this.bnSolve.Name = "bnSolve";
            this.bnSolve.Size = new System.Drawing.Size(183, 23);
            this.bnSolve.TabIndex = 15;
            this.bnSolve.Text = "Посчитать";
            this.bnSolve.UseVisualStyleBackColor = true;
            this.bnSolve.Click += new System.EventHandler(this.bnSolve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Перевести HSV в RGB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorShowerStart
            // 
            this.colorShowerStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorShowerStart.Location = new System.Drawing.Point(12, 134);
            this.colorShowerStart.Name = "colorShowerStart";
            this.colorShowerStart.Size = new System.Drawing.Size(163, 50);
            this.colorShowerStart.TabIndex = 17;
            this.colorShowerStart.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Итоговый цвет";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // colorShowerRes
            // 
            this.colorShowerRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorShowerRes.Location = new System.Drawing.Point(388, 134);
            this.colorShowerRes.Name = "colorShowerRes";
            this.colorShowerRes.Size = new System.Drawing.Size(158, 50);
            this.colorShowerRes.TabIndex = 19;
            this.colorShowerRes.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Начальный цвет";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(558, 196);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colorShowerRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorShowerStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bnSolve);
            this.Controls.Add(this.labelVB);
            this.Controls.Add(this.labelSG);
            this.Controls.Add(this.labelHR);
            this.Controls.Add(this.txtResV);
            this.Controls.Add(this.txtResS);
            this.Controls.Add(this.txtResH);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtH);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Конвертер цветов";
            ((System.ComponentModel.ISupportInitialize)(this.colorShowerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorShowerRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox txtH;
        private TextBox txtS;
        private TextBox txtV;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbOperation;
        private TextBox txtTerm;
        private ComboBox cmbTypes;
        private TextBox txtResH;
        private TextBox txtResS;
        private TextBox txtResV;
        private Label labelVB;
        private Label labelSG;
        private Label labelHR;
        private Button bnSolve;
        private Button button1;
        private PictureBox colorShowerStart;
        private Label label4;
        private PictureBox colorShowerRes;
        private Label label5;
    }
}
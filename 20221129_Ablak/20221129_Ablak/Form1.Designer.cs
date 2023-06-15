namespace _20221129_Ablak
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiz = new System.Windows.Forms.TextBox();
            this.txtTav = new System.Windows.Forms.TextBox();
            this.cbOsztaly = new System.Windows.Forms.ComboBox();
            this.rbtnNincs = new System.Windows.Forms.RadioButton();
            this.rbt50 = new System.Windows.Forms.RadioButton();
            this.rbtn_70 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFAlj = new System.Windows.Forms.ToolStripMenuItem();
            this.msSzamol = new System.Windows.Forms.ToolStripMenuItem();
            this.msKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(541, 40);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(200, 191);
            this.btnSzamol.TabIndex = 1;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Megttet távolság";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Osztály";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kedvezmény";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "fizetendő";
            // 
            // txtFiz
            // 
            this.txtFiz.Location = new System.Drawing.Point(215, 363);
            this.txtFiz.Name = "txtFiz";
            this.txtFiz.Size = new System.Drawing.Size(125, 27);
            this.txtFiz.TabIndex = 6;
            // 
            // txtTav
            // 
            this.txtTav.Location = new System.Drawing.Point(215, 75);
            this.txtTav.Name = "txtTav";
            this.txtTav.Size = new System.Drawing.Size(125, 27);
            this.txtTav.TabIndex = 7;
            // 
            // cbOsztaly
            // 
            this.cbOsztaly.FormattingEnabled = true;
            this.cbOsztaly.Location = new System.Drawing.Point(215, 125);
            this.cbOsztaly.Name = "cbOsztaly";
            this.cbOsztaly.Size = new System.Drawing.Size(151, 28);
            this.cbOsztaly.TabIndex = 8;
            // 
            // rbtnNincs
            // 
            this.rbtnNincs.AutoSize = true;
            this.rbtnNincs.Location = new System.Drawing.Point(178, 220);
            this.rbtnNincs.Name = "rbtnNincs";
            this.rbtnNincs.Size = new System.Drawing.Size(152, 24);
            this.rbtnNincs.TabIndex = 9;
            this.rbtnNincs.TabStop = true;
            this.rbtnNincs.Text = "Nincs kedvezmény";
            this.rbtnNincs.UseVisualStyleBackColor = true;
            // 
            // rbt50
            // 
            this.rbt50.AutoSize = true;
            this.rbt50.Location = new System.Drawing.Point(178, 259);
            this.rbt50.Name = "rbt50";
            this.rbt50.Size = new System.Drawing.Size(58, 24);
            this.rbt50.TabIndex = 10;
            this.rbt50.TabStop = true;
            this.rbt50.Text = "50%";
            this.rbt50.UseVisualStyleBackColor = true;
            // 
            // rbtn_70
            // 
            this.rbtn_70.AutoSize = true;
            this.rbtn_70.Location = new System.Drawing.Point(178, 299);
            this.rbtn_70.Name = "rbtn_70";
            this.rbtn_70.Size = new System.Drawing.Size(58, 24);
            this.rbtn_70.TabIndex = 11;
            this.rbtn_70.TabStop = true;
            this.rbtn_70.Text = "70%";
            this.rbtn_70.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFAlj});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFAlj
            // 
            this.msFAlj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSzamol,
            this.msKilep});
            this.msFAlj.Name = "msFAlj";
            this.msFAlj.Size = new System.Drawing.Size(45, 24);
            this.msFAlj.Text = "Fájl";
            // 
            // msSzamol
            // 
            this.msSzamol.Name = "msSzamol";
            this.msSzamol.Size = new System.Drawing.Size(224, 26);
            this.msSzamol.Text = "Számolás";
            // 
            // msKilep
            // 
            this.msKilep.Name = "msKilep";
            this.msKilep.Size = new System.Drawing.Size(224, 26);
            this.msKilep.Text = "Kilépés";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_70);
            this.Controls.Add(this.rbt50);
            this.Controls.Add(this.rbtnNincs);
            this.Controls.Add(this.cbOsztaly);
            this.Controls.Add(this.txtTav);
            this.Controls.Add(this.txtFiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jegyrendelés";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Button btnSzamol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFiz;
        private TextBox txtTav;
        private ComboBox cbOsztaly;
        private RadioButton rbtnNincs;
        private RadioButton rbt50;
        private RadioButton rbtn_70;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem msFAlj;
        private ToolStripMenuItem msSzamol;
        private ToolStripMenuItem msKilep;
    }
}
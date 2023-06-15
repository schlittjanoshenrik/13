namespace pizzeria_gyak
{
    partial class Form1
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
            this.btn_adat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_adat
            // 
            this.btn_adat.Location = new System.Drawing.Point(287, 388);
            this.btn_adat.Name = "btn_adat";
            this.btn_adat.Size = new System.Drawing.Size(107, 44);
            this.btn_adat.TabIndex = 0;
            this.btn_adat.Text = "Adatbevitel";
            this.btn_adat.UseVisualStyleBackColor = true;
            this.btn_adat.Click += new System.EventHandler(this.btn_adat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pizzeria_gyak.Properties.Resources.UwU;
            this.ClientSize = new System.Drawing.Size(681, 508);
            this.Controls.Add(this.btn_adat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_adat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


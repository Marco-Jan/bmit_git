namespace BMI
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
            lblkg = new Label();
            lblcm = new Label();
            txtkg = new TextBox();
            txtcm = new TextBox();
            btncalc = new Button();
            lbloutput = new Label();
            label1 = new Label();
            massSizeop = new Label();
            SuspendLayout();
            // 
            // lblkg
            // 
            lblkg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblkg.Location = new Point(95, 99);
            lblkg.Name = "lblkg";
            lblkg.Size = new Size(100, 23);
            lblkg.TabIndex = 0;
            lblkg.Text = "Gewicht in Kg";
            lblkg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblcm
            // 
            lblcm.AutoSize = true;
            lblcm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblcm.Location = new Point(105, 145);
            lblcm.Name = "lblcm";
            lblcm.Size = new Size(76, 15);
            lblcm.TabIndex = 1;
            lblcm.Text = "Größe in cm";
            lblcm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtkg
            // 
            txtkg.Location = new Point(224, 101);
            txtkg.Name = "txtkg";
            txtkg.Size = new Size(100, 23);
            txtkg.TabIndex = 2;
            txtkg.Text = "80";
            // 
            // txtcm
            // 
            txtcm.Location = new Point(224, 142);
            txtcm.Name = "txtcm";
            txtcm.Size = new Size(100, 23);
            txtcm.TabIndex = 3;
            // 
            // btncalc
            // 
            btncalc.Location = new Point(224, 203);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(75, 23);
            btncalc.TabIndex = 4;
            btncalc.Text = "Berechnen";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // lbloutput
            // 
            lbloutput.BorderStyle = BorderStyle.FixedSingle;
            lbloutput.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbloutput.Location = new Point(484, 106);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(100, 43);
            lbloutput.TabIndex = 5;
            lbloutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 115);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 6;
            label1.Text = "Ihr BMI beträgt";
            // 
            // massSizeop
            // 
            massSizeop.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            massSizeop.Location = new Point(421, 199);
            massSizeop.Name = "massSizeop";
            massSizeop.Size = new Size(230, 104);
            massSizeop.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(massSizeop);
            Controls.Add(label1);
            Controls.Add(lbloutput);
            Controls.Add(btncalc);
            Controls.Add(txtcm);
            Controls.Add(txtkg);
            Controls.Add(lblcm);
            Controls.Add(lblkg);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblkg;
        private Label lblcm;
        private TextBox txtkg;
        private TextBox txtcm;
        private Button btncalc;
        private Label lbloutput;
        private Label label1;
        private Label massSizeop;
    }
}
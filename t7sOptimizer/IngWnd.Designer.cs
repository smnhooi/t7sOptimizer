namespace t7sOptimizer
{
    partial class IngWnd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ATKNUD = new System.Windows.Forms.NumericUpDown();
            this.HPNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.IdolCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OkB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ATKNUD);
            this.panel1.Controls.Add(this.HPNUD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IdolCB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 129);
            this.panel1.TabIndex = 0;
            // 
            // OkB
            // 
            this.OkB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OkB.Location = new System.Drawing.Point(354, 82);
            this.OkB.Name = "OkB";
            this.OkB.Size = new System.Drawing.Size(150, 30);
            this.OkB.TabIndex = 15;
            this.OkB.Text = "OK";
            this.OkB.UseVisualStyleBackColor = true;
            this.OkB.Click += new System.EventHandler(this.OkB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(265, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "ATK";
            // 
            // ATKNUD
            // 
            this.ATKNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ATKNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ATKNUD.Location = new System.Drawing.Point(321, 47);
            this.ATKNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ATKNUD.Name = "ATKNUD";
            this.ATKNUD.Size = new System.Drawing.Size(183, 29);
            this.ATKNUD.TabIndex = 13;
            // 
            // HPNUD
            // 
            this.HPNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HPNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.HPNUD.Location = new System.Drawing.Point(56, 47);
            this.HPNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HPNUD.Name = "HPNUD";
            this.HPNUD.Size = new System.Drawing.Size(183, 29);
            this.HPNUD.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "HP";
            // 
            // IdolCB
            // 
            this.IdolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdolCB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IdolCB.FormattingEnabled = true;
            this.IdolCB.Location = new System.Drawing.Point(12, 12);
            this.IdolCB.Name = "IdolCB";
            this.IdolCB.Size = new System.Drawing.Size(175, 29);
            this.IdolCB.TabIndex = 3;
            this.IdolCB.SelectedIndexChanged += new System.EventHandler(this.IdolCB_SelectedIndexChanged);
            // 
            // IngWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 125);
            this.Controls.Add(this.panel1);
            this.Name = "IngWnd";
            this.Text = "i-n-g";
            this.Load += new System.EventHandler(this.IngWnd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATKNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox IdolCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ATKNUD;
        private System.Windows.Forms.NumericUpDown HPNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkB;
    }
}
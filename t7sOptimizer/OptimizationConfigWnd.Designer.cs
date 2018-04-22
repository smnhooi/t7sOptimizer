namespace t7sOptimizer
{
    partial class OptimizationConfigWnd
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
            this.IndividualNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StepNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OkB = new System.Windows.Forms.Button();
            this.SparkleNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxMemNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndividualNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SparkleNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMemNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MaxMemNUD);
            this.panel1.Controls.Add(this.IndividualNUD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StepNUD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OkB);
            this.panel1.Controls.Add(this.SparkleNUD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 267);
            this.panel1.TabIndex = 0;
            // 
            // IndividualNUD
            // 
            this.IndividualNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IndividualNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.IndividualNUD.Location = new System.Drawing.Point(139, 79);
            this.IndividualNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IndividualNUD.Name = "IndividualNUD";
            this.IndividualNUD.Size = new System.Drawing.Size(120, 29);
            this.IndividualNUD.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Individual";
            // 
            // StepNUD
            // 
            this.StepNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StepNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.StepNUD.Location = new System.Drawing.Point(139, 44);
            this.StepNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.StepNUD.Name = "StepNUD";
            this.StepNUD.Size = new System.Drawing.Size(120, 29);
            this.StepNUD.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Step";
            // 
            // OkB
            // 
            this.OkB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OkB.Location = new System.Drawing.Point(310, 222);
            this.OkB.Name = "OkB";
            this.OkB.Size = new System.Drawing.Size(150, 30);
            this.OkB.TabIndex = 16;
            this.OkB.Text = "OK";
            this.OkB.UseVisualStyleBackColor = true;
            this.OkB.Click += new System.EventHandler(this.OkB_Click);
            // 
            // SparkleNUD
            // 
            this.SparkleNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SparkleNUD.Location = new System.Drawing.Point(139, 9);
            this.SparkleNUD.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SparkleNUD.Name = "SparkleNUD";
            this.SparkleNUD.Size = new System.Drawing.Size(120, 29);
            this.SparkleNUD.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "min. Sparkle";
            // 
            // MaxMemNUD
            // 
            this.MaxMemNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxMemNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MaxMemNUD.Location = new System.Drawing.Point(139, 114);
            this.MaxMemNUD.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.MaxMemNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxMemNUD.Name = "MaxMemNUD";
            this.MaxMemNUD.Size = new System.Drawing.Size(120, 29);
            this.MaxMemNUD.TabIndex = 21;
            this.MaxMemNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Max Member";
            // 
            // OptimizationConfigWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 348);
            this.Controls.Add(this.panel1);
            this.Name = "OptimizationConfigWnd";
            this.Text = "Optimization Config";
            this.Load += new System.EventHandler(this.OptimizationConfigWnd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndividualNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SparkleNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMemNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown SparkleNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkB;
        private System.Windows.Forms.NumericUpDown IndividualNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StepNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MaxMemNUD;
    }
}
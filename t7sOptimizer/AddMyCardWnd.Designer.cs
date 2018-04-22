namespace t7sOptimizer
{
    partial class AddMyCardWnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdolFChB = new System.Windows.Forms.CheckBox();
            this.IdolCB = new System.Windows.Forms.ComboBox();
            this.RarityFChB = new System.Windows.Forms.CheckBox();
            this.RarityCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NotHoldChB = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SparkleNUD = new System.Windows.Forms.NumericUpDown();
            this.DeleteCardInfoB = new System.Windows.Forms.Button();
            this.AddCardInfoB = new System.Windows.Forms.Button();
            this.CardInfoLV = new System.Windows.Forms.ListView();
            this.IdolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RarityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sparkle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CradId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SparkleNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 144);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // IdolFChB
            // 
            this.IdolFChB.AutoSize = true;
            this.IdolFChB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IdolFChB.Location = new System.Drawing.Point(16, 35);
            this.IdolFChB.Name = "IdolFChB";
            this.IdolFChB.Size = new System.Drawing.Size(61, 26);
            this.IdolFChB.TabIndex = 1;
            this.IdolFChB.Text = "Idol";
            this.IdolFChB.UseVisualStyleBackColor = true;
            this.IdolFChB.CheckedChanged += new System.EventHandler(this.IdolFChB_CheckedChanged);
            // 
            // IdolCB
            // 
            this.IdolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdolCB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IdolCB.FormattingEnabled = true;
            this.IdolCB.Location = new System.Drawing.Point(97, 35);
            this.IdolCB.Name = "IdolCB";
            this.IdolCB.Size = new System.Drawing.Size(175, 29);
            this.IdolCB.TabIndex = 2;
            this.IdolCB.SelectedIndexChanged += new System.EventHandler(this.IdolCB_SelectedIndexChanged);
            // 
            // RarityFChB
            // 
            this.RarityFChB.AutoSize = true;
            this.RarityFChB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RarityFChB.Location = new System.Drawing.Point(16, 70);
            this.RarityFChB.Name = "RarityFChB";
            this.RarityFChB.Size = new System.Drawing.Size(84, 26);
            this.RarityFChB.TabIndex = 3;
            this.RarityFChB.Text = "Rarity";
            this.RarityFChB.UseVisualStyleBackColor = true;
            this.RarityFChB.CheckedChanged += new System.EventHandler(this.RarityFChB_CheckedChanged);
            // 
            // RarityCB
            // 
            this.RarityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RarityCB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RarityCB.FormattingEnabled = true;
            this.RarityCB.Location = new System.Drawing.Point(97, 70);
            this.RarityCB.Name = "RarityCB";
            this.RarityCB.Size = new System.Drawing.Size(175, 29);
            this.RarityCB.TabIndex = 4;
            this.RarityCB.SelectedIndexChanged += new System.EventHandler(this.RarityCB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CardInfoLV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 306);
            this.panel2.TabIndex = 1;
            // 
            // NotHoldChB
            // 
            this.NotHoldChB.AutoSize = true;
            this.NotHoldChB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NotHoldChB.Location = new System.Drawing.Point(16, 105);
            this.NotHoldChB.Name = "NotHoldChB";
            this.NotHoldChB.Size = new System.Drawing.Size(154, 26);
            this.NotHoldChB.TabIndex = 5;
            this.NotHoldChB.Text = "Not Hold Ony";
            this.NotHoldChB.UseVisualStyleBackColor = true;
            this.NotHoldChB.CheckedChanged += new System.EventHandler(this.NotHoldChB_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DeleteCardInfoB);
            this.panel3.Controls.Add(this.AddCardInfoB);
            this.panel3.Controls.Add(this.SparkleNUD);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 144);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NotHoldChB);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.RarityCB);
            this.panel4.Controls.Add(this.IdolCB);
            this.panel4.Controls.Add(this.RarityFChB);
            this.panel4.Controls.Add(this.IdolFChB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 144);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(319, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sparkle";
            // 
            // SparkleNUD
            // 
            this.SparkleNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SparkleNUD.Location = new System.Drawing.Point(403, 42);
            this.SparkleNUD.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SparkleNUD.Name = "SparkleNUD";
            this.SparkleNUD.Size = new System.Drawing.Size(120, 29);
            this.SparkleNUD.TabIndex = 8;
            // 
            // DeleteCardInfoB
            // 
            this.DeleteCardInfoB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteCardInfoB.Location = new System.Drawing.Point(475, 77);
            this.DeleteCardInfoB.Name = "DeleteCardInfoB";
            this.DeleteCardInfoB.Size = new System.Drawing.Size(150, 30);
            this.DeleteCardInfoB.TabIndex = 13;
            this.DeleteCardInfoB.Text = "Leave";
            this.DeleteCardInfoB.UseVisualStyleBackColor = true;
            this.DeleteCardInfoB.Click += new System.EventHandler(this.DeleteCardInfoB_Click);
            // 
            // AddCardInfoB
            // 
            this.AddCardInfoB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddCardInfoB.Location = new System.Drawing.Point(319, 77);
            this.AddCardInfoB.Name = "AddCardInfoB";
            this.AddCardInfoB.Size = new System.Drawing.Size(150, 30);
            this.AddCardInfoB.TabIndex = 12;
            this.AddCardInfoB.Text = "Hold／Edit";
            this.AddCardInfoB.UseVisualStyleBackColor = true;
            this.AddCardInfoB.Click += new System.EventHandler(this.AddCardInfoB_Click);
            // 
            // CardInfoLV
            // 
            this.CardInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdolName,
            this.CardName,
            this.RarityName,
            this.Hold,
            this.Sparkle,
            this.CradId});
            this.CardInfoLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardInfoLV.FullRowSelect = true;
            this.CardInfoLV.GridLines = true;
            this.CardInfoLV.Location = new System.Drawing.Point(0, 0);
            this.CardInfoLV.MultiSelect = false;
            this.CardInfoLV.Name = "CardInfoLV";
            this.CardInfoLV.Size = new System.Drawing.Size(800, 306);
            this.CardInfoLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CardInfoLV.TabIndex = 2;
            this.CardInfoLV.UseCompatibleStateImageBehavior = false;
            this.CardInfoLV.View = System.Windows.Forms.View.Details;
            this.CardInfoLV.SelectedIndexChanged += new System.EventHandler(this.CardInfoLV_SelectedIndexChanged);
            // 
            // IdolName
            // 
            this.IdolName.Text = "アイドル名";
            this.IdolName.Width = 100;
            // 
            // CardName
            // 
            this.CardName.Text = "カード名";
            this.CardName.Width = 200;
            // 
            // RarityName
            // 
            this.RarityName.Text = "レア度";
            // 
            // Hold
            // 
            this.Hold.Text = "所持";
            // 
            // Sparkle
            // 
            this.Sparkle.Text = "Idol☆Sparkle";
            this.Sparkle.Width = 91;
            // 
            // CradId
            // 
            this.CradId.Text = "カードID";
            // 
            // AddMyCardWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMyCardWnd";
            this.Text = "AddMyCardWnd";
            this.Load += new System.EventHandler(this.AddMyCardWnd_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SparkleNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RarityCB;
        private System.Windows.Forms.CheckBox RarityFChB;
        private System.Windows.Forms.ComboBox IdolCB;
        private System.Windows.Forms.CheckBox IdolFChB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox NotHoldChB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown SparkleNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteCardInfoB;
        private System.Windows.Forms.Button AddCardInfoB;
        private System.Windows.Forms.ListView CardInfoLV;
        private System.Windows.Forms.ColumnHeader IdolName;
        private System.Windows.Forms.ColumnHeader CardName;
        private System.Windows.Forms.ColumnHeader RarityName;
        private System.Windows.Forms.ColumnHeader Hold;
        private System.Windows.Forms.ColumnHeader Sparkle;
        private System.Windows.Forms.ColumnHeader CradId;
    }
}
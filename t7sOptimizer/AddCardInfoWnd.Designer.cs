namespace t7sOptimizer
{
    partial class AddCardInfoWnd
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
            this.IdolCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RarityCB = new System.Windows.Forms.ComboBox();
            this.TCCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CardInfoLV = new System.Windows.Forms.ListView();
            this.IdolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RarityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCardId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCardInfoB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HPNUD = new System.Windows.Forms.NumericUpDown();
            this.ATKNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteCardInfoB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATKNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // IdolCB
            // 
            this.IdolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdolCB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IdolCB.FormattingEnabled = true;
            this.IdolCB.Location = new System.Drawing.Point(12, 12);
            this.IdolCB.Name = "IdolCB";
            this.IdolCB.Size = new System.Drawing.Size(150, 29);
            this.IdolCB.TabIndex = 0;
            this.IdolCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteCardInfoB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ATKNUD);
            this.panel1.Controls.Add(this.HPNUD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddCardInfoB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CardNameTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TCCB);
            this.panel1.Controls.Add(this.RarityCB);
            this.panel1.Controls.Add(this.IdolCB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 174);
            this.panel1.TabIndex = 1;
            // 
            // RarityCB
            // 
            this.RarityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RarityCB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RarityCB.FormattingEnabled = true;
            this.RarityCB.Location = new System.Drawing.Point(168, 12);
            this.RarityCB.Name = "RarityCB";
            this.RarityCB.Size = new System.Drawing.Size(150, 29);
            this.RarityCB.TabIndex = 1;
            this.RarityCB.SelectedIndexChanged += new System.EventHandler(this.RarityCB_SelectedIndexChanged);
            // 
            // TCCB
            // 
            this.TCCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCCB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TCCB.FormattingEnabled = true;
            this.TCCB.Location = new System.Drawing.Point(439, 12);
            this.TCCB.Name = "TCCB";
            this.TCCB.Size = new System.Drawing.Size(150, 29);
            this.TCCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(350, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "TCType";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CardInfoLV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 276);
            this.panel2.TabIndex = 2;
            // 
            // CardInfoLV
            // 
            this.CardInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdolName,
            this.CardName,
            this.RarityName,
            this.LVCardId});
            this.CardInfoLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardInfoLV.FullRowSelect = true;
            this.CardInfoLV.GridLines = true;
            this.CardInfoLV.Location = new System.Drawing.Point(0, 0);
            this.CardInfoLV.MultiSelect = false;
            this.CardInfoLV.Name = "CardInfoLV";
            this.CardInfoLV.Size = new System.Drawing.Size(671, 276);
            this.CardInfoLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CardInfoLV.TabIndex = 1;
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
            // LVCardId
            // 
            this.LVCardId.Text = "カードID";
            // 
            // CardNameTB
            // 
            this.CardNameTB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CardNameTB.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.CardNameTB.Location = new System.Drawing.Point(130, 47);
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(459, 29);
            this.CardNameTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card Name";
            // 
            // AddCardInfoB
            // 
            this.AddCardInfoB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddCardInfoB.Location = new System.Drawing.Point(16, 117);
            this.AddCardInfoB.Name = "AddCardInfoB";
            this.AddCardInfoB.Size = new System.Drawing.Size(150, 30);
            this.AddCardInfoB.TabIndex = 6;
            this.AddCardInfoB.Text = "Add ";
            this.AddCardInfoB.UseVisualStyleBackColor = true;
            this.AddCardInfoB.Click += new System.EventHandler(this.AddCardInfoB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "HP";
            // 
            // HPNUD
            // 
            this.HPNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HPNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.HPNUD.Location = new System.Drawing.Point(56, 82);
            this.HPNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HPNUD.Name = "HPNUD";
            this.HPNUD.Size = new System.Drawing.Size(183, 29);
            this.HPNUD.TabIndex = 8;
            this.HPNUD.Enter += new System.EventHandler(this.HPNUD_Enter);
            // 
            // ATKNUD
            // 
            this.ATKNUD.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ATKNUD.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.ATKNUD.Location = new System.Drawing.Point(324, 82);
            this.ATKNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ATKNUD.Name = "ATKNUD";
            this.ATKNUD.Size = new System.Drawing.Size(183, 29);
            this.ATKNUD.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(268, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "ATK";
            // 
            // DeleteCardInfoB
            // 
            this.DeleteCardInfoB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteCardInfoB.Location = new System.Drawing.Point(172, 117);
            this.DeleteCardInfoB.Name = "DeleteCardInfoB";
            this.DeleteCardInfoB.Size = new System.Drawing.Size(150, 30);
            this.DeleteCardInfoB.TabIndex = 11;
            this.DeleteCardInfoB.Text = "Delete";
            this.DeleteCardInfoB.UseVisualStyleBackColor = true;
            this.DeleteCardInfoB.Click += new System.EventHandler(this.DeleteCardInfoB_Click);
            // 
            // AddCardInfoWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddCardInfoWnd";
            this.Text = "AddCardInfoWnd";
            this.Load += new System.EventHandler(this.AddCardInfoWnd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HPNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATKNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox IdolCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RarityCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TCCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView CardInfoLV;
        private System.Windows.Forms.ColumnHeader IdolName;
        private System.Windows.Forms.ColumnHeader CardName;
        private System.Windows.Forms.ColumnHeader RarityName;
        private System.Windows.Forms.ColumnHeader LVCardId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CardNameTB;
        private System.Windows.Forms.Button AddCardInfoB;
        private System.Windows.Forms.NumericUpDown HPNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ATKNUD;
        private System.Windows.Forms.Button DeleteCardInfoB;
    }
}
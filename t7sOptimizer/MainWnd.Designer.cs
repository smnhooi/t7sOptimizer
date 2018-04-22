namespace t7sOptimizer
{
    partial class MainWnd
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCardInfoB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OptB = new System.Windows.Forms.Button();
            this.OptMode = new System.Windows.Forms.ComboBox();
            this.OptConfigB = new System.Windows.Forms.Button();
            this.IngB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StepPB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCardInfoB
            // 
            this.AddCardInfoB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddCardInfoB.Location = new System.Drawing.Point(12, 12);
            this.AddCardInfoB.Name = "AddCardInfoB";
            this.AddCardInfoB.Size = new System.Drawing.Size(150, 50);
            this.AddCardInfoB.TabIndex = 0;
            this.AddCardInfoB.Text = "Add Card Info";
            this.AddCardInfoB.UseVisualStyleBackColor = true;
            this.AddCardInfoB.Click += new System.EventHandler(this.AddCardInfoB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StepPB);
            this.panel1.Controls.Add(this.OptB);
            this.panel1.Controls.Add(this.OptMode);
            this.panel1.Controls.Add(this.OptConfigB);
            this.panel1.Controls.Add(this.IngB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddCardInfoB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 195);
            this.panel1.TabIndex = 1;
            // 
            // OptB
            // 
            this.OptB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OptB.Location = new System.Drawing.Point(324, 68);
            this.OptB.Name = "OptB";
            this.OptB.Size = new System.Drawing.Size(150, 50);
            this.OptB.TabIndex = 5;
            this.OptB.Text = "Optimize";
            this.OptB.UseVisualStyleBackColor = true;
            this.OptB.Click += new System.EventHandler(this.OptB_Click);
            // 
            // OptMode
            // 
            this.OptMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptMode.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OptMode.FormattingEnabled = true;
            this.OptMode.Items.AddRange(new object[] {
            "ライブ：ボーカル",
            "ライブ：バラドル",
            "ライブ：モデル",
            "ライブ：プレイヤー",
            "ライブ：ダンサー",
            "バトル：ATK"});
            this.OptMode.Location = new System.Drawing.Point(12, 68);
            this.OptMode.Name = "OptMode";
            this.OptMode.Size = new System.Drawing.Size(306, 29);
            this.OptMode.TabIndex = 4;
            // 
            // OptConfigB
            // 
            this.OptConfigB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OptConfigB.Location = new System.Drawing.Point(480, 12);
            this.OptConfigB.Name = "OptConfigB";
            this.OptConfigB.Size = new System.Drawing.Size(150, 50);
            this.OptConfigB.TabIndex = 3;
            this.OptConfigB.Text = "Optimization";
            this.OptConfigB.UseVisualStyleBackColor = true;
            this.OptConfigB.Click += new System.EventHandler(this.button2_Click);
            // 
            // IngB
            // 
            this.IngB.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IngB.Location = new System.Drawing.Point(324, 12);
            this.IngB.Name = "IngB";
            this.IngB.Size = new System.Drawing.Size(150, 50);
            this.IngB.TabIndex = 2;
            this.IngB.Text = "i-n-g";
            this.IngB.UseVisualStyleBackColor = true;
            this.IngB.Click += new System.EventHandler(this.IngB_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(168, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add My Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 255);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(647, 255);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // StepPB
            // 
            this.StepPB.Location = new System.Drawing.Point(12, 124);
            this.StepPB.Name = "StepPB";
            this.StepPB.Size = new System.Drawing.Size(618, 23);
            this.StepPB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Progress State";
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWnd";
            this.Text = "t7sOptimizer";
            this.Load += new System.EventHandler(this.MainWnd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCardInfoB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IngB;
        private System.Windows.Forms.Button OptConfigB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox OptMode;
        private System.Windows.Forms.Button OptB;
        private System.Windows.Forms.ProgressBar StepPB;
        private System.Windows.Forms.Label label3;
    }
}


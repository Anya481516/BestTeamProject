namespace BestTeamProject
{
    partial class FrmFilters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilters));
            this.label12 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.gpbColor = new System.Windows.Forms.GroupBox();
            this.ckbRed = new System.Windows.Forms.CheckBox();
            this.ckbGrey = new System.Windows.Forms.CheckBox();
            this.ckbBlack = new System.Windows.Forms.CheckBox();
            this.tkbMaxPrice = new System.Windows.Forms.TrackBar();
            this.tkbMinPrice = new System.Windows.Forms.TrackBar();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMinPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(11, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 39;
            this.label12.Text = "Цена";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDone.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDone.Location = new System.Drawing.Point(12, 167);
            this.btnDone.Margin = new System.Windows.Forms.Padding(0);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(463, 32);
            this.btnDone.TabIndex = 45;
            this.btnDone.Text = "Готово";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // gpbColor
            // 
            this.gpbColor.Controls.Add(this.ckbRed);
            this.gpbColor.Controls.Add(this.ckbGrey);
            this.gpbColor.Controls.Add(this.ckbBlack);
            this.gpbColor.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbColor.Location = new System.Drawing.Point(12, 12);
            this.gpbColor.Name = "gpbColor";
            this.gpbColor.Size = new System.Drawing.Size(455, 74);
            this.gpbColor.TabIndex = 42;
            this.gpbColor.TabStop = false;
            this.gpbColor.Text = "Цвет";
            // 
            // ckbRed
            // 
            this.ckbRed.AutoSize = true;
            this.ckbRed.BackColor = System.Drawing.Color.Red;
            this.ckbRed.Location = new System.Drawing.Point(124, 42);
            this.ckbRed.Name = "ckbRed";
            this.ckbRed.Size = new System.Drawing.Size(95, 26);
            this.ckbRed.TabIndex = 2;
            this.ckbRed.Text = "Красный";
            this.ckbRed.UseVisualStyleBackColor = false;
            // 
            // ckbGrey
            // 
            this.ckbGrey.AutoSize = true;
            this.ckbGrey.BackColor = System.Drawing.Color.DimGray;
            this.ckbGrey.Location = new System.Drawing.Point(310, 14);
            this.ckbGrey.Name = "ckbGrey";
            this.ckbGrey.Size = new System.Drawing.Size(75, 26);
            this.ckbGrey.TabIndex = 1;
            this.ckbGrey.Text = "Серый";
            this.ckbGrey.UseVisualStyleBackColor = false;
            // 
            // ckbBlack
            // 
            this.ckbBlack.AutoSize = true;
            this.ckbBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbBlack.ForeColor = System.Drawing.Color.White;
            this.ckbBlack.Location = new System.Drawing.Point(124, 14);
            this.ckbBlack.Name = "ckbBlack";
            this.ckbBlack.Size = new System.Drawing.Size(87, 26);
            this.ckbBlack.TabIndex = 0;
            this.ckbBlack.Text = "Черный";
            this.ckbBlack.UseVisualStyleBackColor = false;
            // 
            // tkbMaxPrice
            // 
            this.tkbMaxPrice.Location = new System.Drawing.Point(362, 103);
            this.tkbMaxPrice.Maximum = 3000;
            this.tkbMaxPrice.Minimum = 1000;
            this.tkbMaxPrice.Name = "tkbMaxPrice";
            this.tkbMaxPrice.Size = new System.Drawing.Size(104, 45);
            this.tkbMaxPrice.TabIndex = 60;
            this.tkbMaxPrice.Value = 3000;
            this.tkbMaxPrice.Scroll += new System.EventHandler(this.tkbMaxPrice_Scroll);
            // 
            // tkbMinPrice
            // 
            this.tkbMinPrice.Location = new System.Drawing.Point(108, 103);
            this.tkbMinPrice.Maximum = 3000;
            this.tkbMinPrice.Minimum = 1000;
            this.tkbMinPrice.Name = "tkbMinPrice";
            this.tkbMinPrice.Size = new System.Drawing.Size(104, 45);
            this.tkbMinPrice.TabIndex = 59;
            this.tkbMinPrice.Value = 1000;
            this.tkbMinPrice.Scroll += new System.EventHandler(this.tkbMinPrice_Scroll);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMaxPrice.Location = new System.Drawing.Point(322, 112);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(39, 25);
            this.txtMaxPrice.TabIndex = 70;
            this.txtMaxPrice.Text = "3000";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinPrice.Location = new System.Drawing.Point(215, 103);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(40, 25);
            this.txtMinPrice.TabIndex = 69;
            this.txtMinPrice.Text = "1000";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(257, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "x1000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(363, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "x1000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.tkbMaxPrice);
            this.Controls.Add(this.tkbMinPrice);
            this.Controls.Add(this.gpbColor);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFilters";
            this.Text = "Выбор нужных характеристик";
            this.gpbColor.ResumeLayout(false);
            this.gpbColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMinPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox gpbColor;
        private System.Windows.Forms.CheckBox ckbRed;
        private System.Windows.Forms.CheckBox ckbGrey;
        private System.Windows.Forms.CheckBox ckbBlack;
        private System.Windows.Forms.TrackBar tkbMaxPrice;
        private System.Windows.Forms.TrackBar tkbMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
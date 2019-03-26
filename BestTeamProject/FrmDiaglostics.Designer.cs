namespace BestTeamProject
{
    partial class FrmDiaglostics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiaglostics));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxTime = new System.Windows.Forms.ListBox();
            this.btnPognaliVyberem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Lato Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Location = new System.Drawing.Point(48, 188);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пожалуйста выбирите свободный день и время для диагностики вашего автомобиля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxTime
            // 
            this.lbxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxTime.Font = new System.Drawing.Font("Lato Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxTime.FormattingEnabled = true;
            this.lbxTime.ItemHeight = 16;
            this.lbxTime.Items.AddRange(new object[] {
            "9:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "12:00-13:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00",
            "17:00-18:00",
            "18:00-19:00",
            "19:00-20:00",
            "20:00-21:00"});
            this.lbxTime.Location = new System.Drawing.Point(317, 188);
            this.lbxTime.Name = "lbxTime";
            this.lbxTime.Size = new System.Drawing.Size(108, 180);
            this.lbxTime.TabIndex = 3;
            // 
            // btnPognaliVyberem
            // 
            this.btnPognaliVyberem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPognaliVyberem.BackColor = System.Drawing.Color.White;
            this.btnPognaliVyberem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPognaliVyberem.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPognaliVyberem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPognaliVyberem.Location = new System.Drawing.Point(12, 388);
            this.btnPognaliVyberem.Margin = new System.Windows.Forms.Padding(0);
            this.btnPognaliVyberem.Name = "btnPognaliVyberem";
            this.btnPognaliVyberem.Size = new System.Drawing.Size(460, 63);
            this.btnPognaliVyberem.TabIndex = 4;
            this.btnPognaliVyberem.Text = "Забронировать выбранное время";
            this.btnPognaliVyberem.UseVisualStyleBackColor = false;
            this.btnPognaliVyberem.Click += new System.EventHandler(this.btnPognaliVyberem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // FrmDiaglostics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPognaliVyberem);
            this.Controls.Add(this.lbxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmDiaglostics";
            this.Text = "Запись на Диагностику";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTime;
        private System.Windows.Forms.Button btnPognaliVyberem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
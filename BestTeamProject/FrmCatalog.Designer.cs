namespace BestTeamProject
{
    partial class FrmCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьХарактеристикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьХарактеристикиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьХарактеристикиToolStripMenuItem
            // 
            this.выбратьХарактеристикиToolStripMenuItem.Name = "выбратьХарактеристикиToolStripMenuItem";
            this.выбратьХарактеристикиToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.выбратьХарактеристикиToolStripMenuItem.Text = "Выбрать характеристики";
            this.выбратьХарактеристикиToolStripMenuItem.Click += new System.EventHandler(this.выбратьХарактеристикиToolStripMenuItem_Click);
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.BackColor = System.Drawing.Color.White;
            this.btnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMore.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMore.Location = new System.Drawing.Point(834, 27);
            this.btnMore.Margin = new System.Windows.Forms.Padding(0);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(150, 272);
            this.btnMore.TabIndex = 5;
            this.btnMore.Text = "Подробнее о выбранном автомобиле";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.BackColor = System.Drawing.Color.White;
            this.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuy.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuy.Location = new System.Drawing.Point(834, 299);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(150, 150);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(819, 420);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FrmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCatalog";
            this.Text = "Каталог салона";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCatalog_FormClosing);
            this.Load += new System.EventHandler(this.FrmCatalog_Load);
            this.Leave += new System.EventHandler(this.FrmCatalog_Leave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьХарактеристикиToolStripMenuItem;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox listBox1;
    }
}
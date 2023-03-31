namespace UI
{
    partial class UploadExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadExcel));
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            alternativToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(301, 114);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 0;
            button1.Text = "Ladda upp Excelfil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 168);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 1;
            label1.Text = "Nu är din uppladdning klar!";
            label1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(217, 215);
            button2.Name = "button2";
            button2.Size = new Size(325, 34);
            button2.TabIndex = 2;
            button2.Text = "Spara grupper som Word-dokument";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 68);
            label2.Name = "label2";
            label2.Size = new Size(486, 25);
            label2.TabIndex = 3;
            label2.Text = "Här kan du ladda upp en Excelfil från anmälningsformuläret!";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "docx";
            saveFileDialog1.FileName = "Anmälda grupper.docx";
            saveFileDialog1.Filter = "Word Files (*.docx)|*.doc";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alternativToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // alternativToolStripMenuItem
            // 
            alternativToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avslutaToolStripMenuItem });
            alternativToolStripMenuItem.Name = "alternativToolStripMenuItem";
            alternativToolStripMenuItem.Size = new Size(103, 29);
            alternativToolStripMenuItem.Text = "Alternativ";
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(172, 34);
            avslutaToolStripMenuItem.Text = "Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.ForeColor = Color.Black;
            label3.Location = new Point(99, 305);
            label3.Name = "label3";
            label3.Size = new Size(526, 136);
            label3.TabIndex = 5;
            label3.Text = "Fil sparad!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(232, 268);
            button3.Name = "button3";
            button3.Size = new Size(286, 34);
            button3.TabIndex = 6;
            button3.Text = "Spara grupper som Google Docs";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UploadExcel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "UploadExcel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Domen över Hjorvard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button button2;
        private Label label2;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alternativToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private Label label3;
        private Button button3;
    }
}
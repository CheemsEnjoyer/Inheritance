namespace Inheritance
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
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            btnGet = new Button();
            txtOut = new RichTextBox();
            lstDrinkQueue = new ListBox();
            pctrBxDrnk = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctrBxDrnk).BeginInit();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(488, 29);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 47);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(257, 155);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(361, 208);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(139, 198);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 208);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(343, 197);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // lstDrinkQueue
            // 
            lstDrinkQueue.AllowDrop = true;
            lstDrinkQueue.FormattingEnabled = true;
            lstDrinkQueue.Location = new Point(275, 47);
            lstDrinkQueue.Name = "lstDrinkQueue";
            lstDrinkQueue.Size = new Size(225, 144);
            lstDrinkQueue.TabIndex = 4;
            // 
            // pctrBxDrnk
            // 
            pctrBxDrnk.Location = new Point(506, 12);
            pctrBxDrnk.Name = "pctrBxDrnk";
            pctrBxDrnk.Size = new Size(349, 393);
            pctrBxDrnk.TabIndex = 5;
            pctrBxDrnk.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 418);
            Controls.Add(pctrBxDrnk);
            Controls.Add(lstDrinkQueue);
            Controls.Add(txtOut);
            Controls.Add(btnGet);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctrBxDrnk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private Button btnGet;
        private RichTextBox txtOut;
        private ListBox lstDrinkQueue;
        private PictureBox pctrBxDrnk;
    }
}

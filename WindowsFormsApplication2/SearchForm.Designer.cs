namespace WindowsFormsApplication2
{
    partial class SearchForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.printingList = new System.Windows.Forms.ListBox();
            this.cardImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // rulesText
            // 
            this.rulesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rulesText.Cursor = System.Windows.Forms.Cursors.Default;
            this.rulesText.Location = new System.Drawing.Point(24, 239);
            this.rulesText.Name = "rulesText";
            this.rulesText.Size = new System.Drawing.Size(189, 92);
            this.rulesText.TabIndex = 4;
            this.rulesText.Text = "";
            this.rulesText.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.Location = new System.Drawing.Point(244, 30);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(181, 342);
            this.searchResults.TabIndex = 5;
            this.searchResults.Visible = false;
            this.searchResults.SelectedIndexChanged += new System.EventHandler(this.searchResults_SelectedIndexChanged);
            // 
            // printingList
            // 
            this.printingList.FormattingEnabled = true;
            this.printingList.Location = new System.Drawing.Point(245, 30);
            this.printingList.Name = "printingList";
            this.printingList.Size = new System.Drawing.Size(180, 355);
            this.printingList.TabIndex = 6;
            this.printingList.Visible = false;
            this.printingList.SelectedIndexChanged += new System.EventHandler(this.printingList_SelectedIndexChanged);
            // 
            // cardImage
            // 
            this.cardImage.Location = new System.Drawing.Point(0, -1);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(239, 386);
            this.cardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardImage.TabIndex = 7;
            this.cardImage.TabStop = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 386);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.printingList);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.rulesText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "SearchForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rulesText;
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.ListBox printingList;
        private System.Windows.Forms.PictureBox cardImage;

    }
}


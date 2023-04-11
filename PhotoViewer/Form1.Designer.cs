namespace PhotoViewer
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.RotateRight = new System.Windows.Forms.Button();
            this.RotateLeft = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 352);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.DodgerBlue;
            this.Previous.Location = new System.Drawing.Point(12, 379);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(168, 48);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.DodgerBlue;
            this.Open.Location = new System.Drawing.Point(326, 379);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(168, 48);
            this.Open.TabIndex = 3;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.DodgerBlue;
            this.Next.Location = new System.Drawing.Point(620, 379);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(168, 48);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // clearall
            // 
            this.clearall.BackColor = System.Drawing.Color.DarkGray;
            this.clearall.Location = new System.Drawing.Point(592, 433);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(95, 37);
            this.clearall.TabIndex = 5;
            this.clearall.Text = "Clear All";
            this.clearall.UseVisualStyleBackColor = false;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkGray;
            this.exit.Location = new System.Drawing.Point(693, 433);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 37);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RotateRight
            // 
            this.RotateRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RotateRight.Location = new System.Drawing.Point(12, 433);
            this.RotateRight.Name = "RotateRight";
            this.RotateRight.Size = new System.Drawing.Size(95, 37);
            this.RotateRight.TabIndex = 7;
            this.RotateRight.Text = "Rotate Right";
            this.RotateRight.UseVisualStyleBackColor = false;
            this.RotateRight.Click += new System.EventHandler(this.RotateRight_Click);
            // 
            // RotateLeft
            // 
            this.RotateLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RotateLeft.Location = new System.Drawing.Point(113, 433);
            this.RotateLeft.Name = "RotateLeft";
            this.RotateLeft.Size = new System.Drawing.Size(95, 37);
            this.RotateLeft.TabIndex = 8;
            this.RotateLeft.Text = "Rotate Left";
            this.RotateLeft.UseVisualStyleBackColor = false;
            this.RotateLeft.Click += new System.EventHandler(this.RotateLeft_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DarkCyan;
            this.save.Location = new System.Drawing.Point(214, 433);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 37);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.save);
            this.Controls.Add(this.RotateLeft);
            this.Controls.Add(this.RotateRight);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button RotateRight;
        private System.Windows.Forms.Button RotateLeft;
        private System.Windows.Forms.Button save;
    }
}


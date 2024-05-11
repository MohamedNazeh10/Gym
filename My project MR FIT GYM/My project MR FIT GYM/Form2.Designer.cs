namespace My_project_MR_FIT_GYM
{
    partial class Form2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Payment_button = new System.Windows.Forms.Button();
            this.New_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Logout_button);
            this.panel1.Controls.Add(this.Payment_button);
            this.panel1.Controls.Add(this.New_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_project_MR_FIT_GYM.Properties.Resources.logo4;
            this.pictureBox2.Location = new System.Drawing.Point(12, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.SeaShell;
            this.Logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.Location = new System.Drawing.Point(623, 60);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(146, 40);
            this.Logout_button.TabIndex = 3;
            this.Logout_button.Text = "Log out";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Payment_button
            // 
            this.Payment_button.BackColor = System.Drawing.Color.SeaShell;
            this.Payment_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Payment_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Payment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_button.Location = new System.Drawing.Point(428, 60);
            this.Payment_button.Name = "Payment_button";
            this.Payment_button.Size = new System.Drawing.Size(166, 40);
            this.Payment_button.TabIndex = 2;
            this.Payment_button.Text = "Payment";
            this.Payment_button.UseVisualStyleBackColor = false;
            this.Payment_button.Click += new System.EventHandler(this.Payment_button_Click);
            // 
            // New_button
            // 
            this.New_button.BackColor = System.Drawing.Color.SeaShell;
            this.New_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_button.Location = new System.Drawing.Point(87, 60);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(335, 40);
            this.New_button.TabIndex = 1;
            this.New_button.Text = "Add / Update Member";
            this.New_button.UseVisualStyleBackColor = false;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MR FIT GYM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_project_MR_FIT_GYM.Properties.Resources.Background1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Payment_button;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
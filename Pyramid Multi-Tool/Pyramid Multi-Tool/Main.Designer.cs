namespace Pyramid_Multi_Tool
{
    partial class Main
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
            this.Calculator_Button = new System.Windows.Forms.Button();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Task_Manager_Button = new System.Windows.Forms.Button();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculator_Button
            // 
            this.Calculator_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Calculator_Button.FlatAppearance.BorderSize = 0;
            this.Calculator_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculator_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator_Button.Location = new System.Drawing.Point(17, 82);
            this.Calculator_Button.Name = "Calculator_Button";
            this.Calculator_Button.Size = new System.Drawing.Size(181, 45);
            this.Calculator_Button.TabIndex = 0;
            this.Calculator_Button.Text = "Calculator";
            this.Calculator_Button.UseVisualStyleBackColor = true;
            this.Calculator_Button.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(180)))), ((int)(((byte)(107)))));
            this.Top_Panel.Controls.Add(this.Minimize_Button);
            this.Top_Panel.Controls.Add(this.Exit_Button);
            this.Top_Panel.Controls.Add(this.Title);
            this.Top_Panel.Location = new System.Drawing.Point(-4, -4);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(550, 67);
            this.Top_Panel.TabIndex = 1;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_Button.Location = new System.Drawing.Point(314, 12);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(113, 48);
            this.Minimize_Button.TabIndex = 2;
            this.Minimize_Button.Text = "Minimize";
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Mimimize_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(433, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(96, 48);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(16, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(243, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Pyramid Multi-Tool";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // Task_Manager_Button
            // 
            this.Task_Manager_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Task_Manager_Button.FlatAppearance.BorderSize = 0;
            this.Task_Manager_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task_Manager_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Manager_Button.Location = new System.Drawing.Point(17, 142);
            this.Task_Manager_Button.Name = "Task_Manager_Button";
            this.Task_Manager_Button.Size = new System.Drawing.Size(181, 45);
            this.Task_Manager_Button.TabIndex = 2;
            this.Task_Manager_Button.Text = "Task Manager";
            this.Task_Manager_Button.UseVisualStyleBackColor = true;
            this.Task_Manager_Button.Click += new System.EventHandler(this.Task_Manager_Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.Task_Manager_Button);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Calculator_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Pyramid Multi-Tool";
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calculator_Button;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Task_Manager_Button;
    }
}


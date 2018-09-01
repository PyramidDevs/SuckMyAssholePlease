namespace Pyramid_Multi_Tool
{
    partial class TskMngr
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
            this.components = new System.ComponentModel.Container();
            this.Update_Process_List_Button = new System.Windows.Forms.Button();
            this.ProcessRunningNumber = new System.Windows.Forms.Label();
            this.Process_List = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Update_Process_List_Button
            // 
            this.Update_Process_List_Button.Location = new System.Drawing.Point(365, 378);
            this.Update_Process_List_Button.Name = "Update_Process_List_Button";
            this.Update_Process_List_Button.Size = new System.Drawing.Size(124, 60);
            this.Update_Process_List_Button.TabIndex = 0;
            this.Update_Process_List_Button.Text = "Update";
            this.Update_Process_List_Button.UseVisualStyleBackColor = true;
            this.Update_Process_List_Button.Click += new System.EventHandler(this.Update_Process_List_Button_Click);
            // 
            // ProcessRunningNumber
            // 
            this.ProcessRunningNumber.AutoSize = true;
            this.ProcessRunningNumber.Location = new System.Drawing.Point(30, 421);
            this.ProcessRunningNumber.Name = "ProcessRunningNumber";
            this.ProcessRunningNumber.Size = new System.Drawing.Size(141, 17);
            this.ProcessRunningNumber.TabIndex = 2;
            this.ProcessRunningNumber.Text = "Proccesses running: ";
            // 
            // Process_List
            // 
            this.Process_List.ContextMenuStrip = this.contextMenuStrip1;
            this.Process_List.FormattingEnabled = true;
            this.Process_List.ItemHeight = 16;
            this.Process_List.Location = new System.Drawing.Point(21, 25);
            this.Process_List.Name = "Process_List";
            this.Process_List.Size = new System.Drawing.Size(301, 372);
            this.Process_List.Sorted = true;
            this.Process_List.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 28);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TskMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Process_List);
            this.Controls.Add(this.ProcessRunningNumber);
            this.Controls.Add(this.Update_Process_List_Button);
            this.Name = "TskMngr";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_Process_List_Button;
        private System.Windows.Forms.Label ProcessRunningNumber;
        private System.Windows.Forms.ListBox Process_List;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
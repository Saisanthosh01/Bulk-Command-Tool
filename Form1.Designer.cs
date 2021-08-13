
using System.Windows.Forms;

namespace FirstProject
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SingleFilebtn = new System.Windows.Forms.Button();
            this.folderSelectorbtn = new System.Windows.Forms.Button();
            this.Run_Btn = new System.Windows.Forms.Button();
            this.Drag_Button = new System.Windows.Forms.Button();
            this.commandTxt = new System.Windows.Forms.TextBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1204, 115);
            this.topPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1204, 115);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bulk Shell Command Tool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingleFilebtn
            // 
            this.SingleFilebtn.AutoSize = true;
            this.SingleFilebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SingleFilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingleFilebtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.SingleFilebtn.FlatAppearance.BorderSize = 0;
            this.SingleFilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SingleFilebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SingleFilebtn.Location = new System.Drawing.Point(68, 281);
            this.SingleFilebtn.Margin = new System.Windows.Forms.Padding(0);
            this.SingleFilebtn.Name = "SingleFilebtn";
            this.SingleFilebtn.Size = new System.Drawing.Size(355, 55);
            this.SingleFilebtn.TabIndex = 13;
            this.SingleFilebtn.Text = "Click here to add single file";
            this.SingleFilebtn.UseVisualStyleBackColor = false;
            this.SingleFilebtn.Click += new System.EventHandler(this.SingleFileebtn_Click);
            // 
            // folderSelectorbtn
            // 
            this.folderSelectorbtn.AutoSize = true;
            this.folderSelectorbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.folderSelectorbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderSelectorbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.folderSelectorbtn.FlatAppearance.BorderSize = 0;
            this.folderSelectorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderSelectorbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.folderSelectorbtn.Location = new System.Drawing.Point(68, 550);
            this.folderSelectorbtn.Margin = new System.Windows.Forms.Padding(0);
            this.folderSelectorbtn.Name = "folderSelectorbtn";
            this.folderSelectorbtn.Size = new System.Drawing.Size(355, 55);
            this.folderSelectorbtn.TabIndex = 14;
            this.folderSelectorbtn.Text = "Click here to select a folder";
            this.folderSelectorbtn.UseVisualStyleBackColor = false;
            this.folderSelectorbtn.Click += new System.EventHandler(this.FolderSelectorbtn_Click);
            // 
            // Run_Btn
            // 
            this.Run_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Run_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run_Btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Run_Btn.FlatAppearance.BorderSize = 0;
            this.Run_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Run_Btn.Location = new System.Drawing.Point(299, 641);
            this.Run_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Run_Btn.Name = "Run_Btn";
            this.Run_Btn.Size = new System.Drawing.Size(400, 50);
            this.Run_Btn.TabIndex = 15;
            this.Run_Btn.Text = "Click here to Run Command";
            this.Run_Btn.UseVisualStyleBackColor = false;
            this.Run_Btn.Click += new System.EventHandler(this.Run_Btn_Click);
            // 
            // Drag_Button
            // 
            this.Drag_Button.AllowDrop = true;
            this.Drag_Button.AutoSize = true;
            this.Drag_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Drag_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Drag_Button.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Drag_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Drag_Button.FlatAppearance.BorderSize = 0;
            this.Drag_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Drag_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Drag_Button.Location = new System.Drawing.Point(68, 353);
            this.Drag_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Drag_Button.Name = "Drag_Button";
            this.Drag_Button.Size = new System.Drawing.Size(355, 175);
            this.Drag_Button.TabIndex = 16;
            this.Drag_Button.Text = "Click to Browse or Drag and Drop files here";
            this.Drag_Button.UseVisualStyleBackColor = false;
            this.Drag_Button.Click += new System.EventHandler(this.Drag_Button_Click_1);
            this.Drag_Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drag_Button_DragDrop);
            this.Drag_Button.DragOver += new System.Windows.Forms.DragEventHandler(this.Drag_Button_DragOver);
            // 
            // commandTxt
            // 
            this.commandTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.commandTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commandTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.commandTxt.Location = new System.Drawing.Point(66, 140);
            this.commandTxt.MaxLength = 512;
            this.commandTxt.Multiline = true;
            this.commandTxt.Name = "commandTxt";
            this.commandTxt.PlaceholderText = "Input your input command here";
            this.commandTxt.Size = new System.Drawing.Size(1099, 71);
            this.commandTxt.TabIndex = 19;
            // 
            // filesListView
            // 
            this.filesListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.filesListView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.filesListView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filesListView.FullRowSelect = true;
            this.filesListView.GridLines = true;
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(551, 248);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(614, 355);
            this.filesListView.TabIndex = 20;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Input files by one or all or any of below methods";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(738, 641);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Location = new System.Drawing.Point(488, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 325);
            this.panel1.TabIndex = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(91, 768);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(553, 29);
            this.progressBar1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 745);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Progress of command execution";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(823, 768);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Click to Restart the application";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1212, 828);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.commandTxt);
            this.Controls.Add(this.Drag_Button);
            this.Controls.Add(this.Run_Btn);
            this.Controls.Add(this.folderSelectorbtn);
            this.Controls.Add(this.SingleFilebtn);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch Command Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SingleFilebtn;
        private System.Windows.Forms.Button folderSelectorbtn;
        private System.Windows.Forms.Button Run_Btn;
        private System.Windows.Forms.Button Drag_Button;
        private System.Windows.Forms.TextBox commandTxt;
        private System.Windows.Forms.ListView filesListView;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private ProgressBar progressBar1;
        private Label label3;
        private Button button2;
    }
}


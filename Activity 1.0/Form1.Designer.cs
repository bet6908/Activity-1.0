namespace Activity_1._0
{
    partial class Activity1
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
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_goodBye = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_instruction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.BackColor = System.Drawing.Color.Red;
            this.btn_Hello.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Hello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Hello.Location = new System.Drawing.Point(99, 75);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(168, 59);
            this.btn_Hello.TabIndex = 0;
            this.btn_Hello.Text = "Click Me!";
            this.btn_Hello.UseVisualStyleBackColor = false;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Lime;
            this.btn_change.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_change.Location = new System.Drawing.Point(307, 75);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(158, 59);
            this.btn_change.TabIndex = 1;
            this.btn_change.Text = "Next!";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_goodBye
            // 
            this.btn_goodBye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_goodBye.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_goodBye.Location = new System.Drawing.Point(634, 387);
            this.btn_goodBye.Name = "btn_goodBye";
            this.btn_goodBye.Size = new System.Drawing.Size(134, 42);
            this.btn_goodBye.TabIndex = 2;
            this.btn_goodBye.Text = "End";
            this.btn_goodBye.UseVisualStyleBackColor = false;
            this.btn_goodBye.Click += new System.EventHandler(this.btn_goodBye_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(229, 188);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 23);
            this.lbl_info.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Once complete, click \"End\" button.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Read and understood participation requirements",
            "Downloaded Visual Studio",
            "Created GitHub account",
            "Ready to learn"});
            this.checkedListBox1.Location = new System.Drawing.Point(229, 251);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(282, 94);
            this.checkedListBox1.TabIndex = 5;
            // 
            // btn_instruction
            // 
            this.btn_instruction.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_instruction.Location = new System.Drawing.Point(519, 75);
            this.btn_instruction.Name = "btn_instruction";
            this.btn_instruction.Size = new System.Drawing.Size(161, 59);
            this.btn_instruction.TabIndex = 6;
            this.btn_instruction.Text = "Instructions";
            this.btn_instruction.UseVisualStyleBackColor = true;
            this.btn_instruction.Click += new System.EventHandler(this.btn_instruction_Click);
            // 
            // Activity1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_instruction);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_goodBye);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_Hello);
            this.Name = "Activity1";
            this.Text = "Intro: Hello World!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Hello;
        private Button btn_change;
        private Button btn_goodBye;
        private Label lbl_info;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button btn_instruction;
    }
}
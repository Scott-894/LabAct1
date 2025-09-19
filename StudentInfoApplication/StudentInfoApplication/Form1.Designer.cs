namespace StudentInfoApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textID = new TextBox();
            textLname = new TextBox();
            textFname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LbID = new ListBox();
            LbFN = new ListBox();
            LbLN = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(76, 49);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "STUDENT ID*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(303, 49);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 1;
            label2.Text = "STUDENT LAST NAME*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(575, 49);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 2;
            label3.Text = "STUDENT FIRST NAME*";
            // 
            // textID
            // 
            textID.Location = new Point(30, 84);
            textID.Name = "textID";
            textID.Size = new Size(188, 27);
            textID.TabIndex = 3;
            // 
            // textLname
            // 
            textLname.Location = new Point(303, 84);
            textLname.Name = "textLname";
            textLname.Size = new Size(176, 27);
            textLname.TabIndex = 4;
            // 
            // textFname
            // 
            textFname.Location = new Point(572, 84);
            textFname.Name = "textFname";
            textFname.Size = new Size(180, 27);
            textFname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(51, 174);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 6;
            label4.Text = "STUDENT ID LIST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(322, 174);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 7;
            label5.Text = " FIRST NAME LIST";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(610, 174);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 8;
            label6.Text = "LAST NAME LIST";
            // 
            // LbID
            // 
            LbID.FormattingEnabled = true;
            LbID.Location = new Point(30, 215);
            LbID.Name = "LbID";
            LbID.Size = new Size(188, 184);
            LbID.TabIndex = 9;
            // 
            // LbFN
            // 
            LbFN.FormattingEnabled = true;
            LbFN.Location = new Point(292, 215);
            LbFN.Name = "LbFN";
            LbFN.Size = new Size(198, 184);
            LbFN.TabIndex = 10;
            // 
            // LbLN
            // 
            LbLN.FormattingEnabled = true;
            LbLN.Location = new Point(572, 215);
            LbLN.Name = "LbLN";
            LbLN.Size = new Size(196, 184);
            LbLN.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(327, 410);
            button1.Name = "button1";
            button1.Size = new Size(131, 37);
            button1.TabIndex = 12;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LbLN);
            Controls.Add(LbFN);
            Controls.Add(LbID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textFname);
            Controls.Add(textLname);
            Controls.Add(textID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "STUDENT PROFILE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textID;
        private TextBox textLname;
        private TextBox textFname;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox LbID;
        private ListBox LbFN;
        private ListBox LbLN;
        private Button button1;
    }
}

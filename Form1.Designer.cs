namespace WindowsFormsApp3
{
    partial class DroneControler
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.URIBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TriSwitch2 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TriSwitch1 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Pot2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pot1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Toggle2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Toggle1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JoyStick2X = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JoyStick1X = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JoyStick1Y = new System.Windows.Forms.ComboBox();
            this.JoyStick2Y = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 236);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // URIBox
            // 
            this.URIBox.Location = new System.Drawing.Point(363, 190);
            this.URIBox.Name = "URIBox";
            this.URIBox.Size = new System.Drawing.Size(100, 22);
            this.URIBox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "IP/URI:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 189);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 83;
            this.button3.Text = "Gimble Calibration";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 82;
            this.button2.Text = "Save And Sync";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "Load From Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TriSwitch2
            // 
            this.TriSwitch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TriSwitch2.FormattingEnabled = true;
            this.TriSwitch2.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.TriSwitch2.Location = new System.Drawing.Point(115, 159);
            this.TriSwitch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TriSwitch2.Name = "TriSwitch2";
            this.TriSwitch2.Size = new System.Drawing.Size(133, 24);
            this.TriSwitch2.TabIndex = 80;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(30, 163);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 17);
            this.label28.TabIndex = 79;
            this.label28.Text = "TriSwitch 2:";
            // 
            // TriSwitch1
            // 
            this.TriSwitch1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TriSwitch1.FormattingEnabled = true;
            this.TriSwitch1.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.TriSwitch1.Location = new System.Drawing.Point(115, 131);
            this.TriSwitch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TriSwitch1.Name = "TriSwitch1";
            this.TriSwitch1.Size = new System.Drawing.Size(133, 24);
            this.TriSwitch1.TabIndex = 78;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(30, 134);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 17);
            this.label24.TabIndex = 77;
            this.label24.Text = "TriSwitch 1:";
            // 
            // Pot2
            // 
            this.Pot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pot2.FormattingEnabled = true;
            this.Pot2.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.Pot2.Location = new System.Drawing.Point(475, 40);
            this.Pot2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pot2.Name = "Pot2";
            this.Pot2.Size = new System.Drawing.Size(133, 24);
            this.Pot2.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Potentiometer 2";
            // 
            // Pot1
            // 
            this.Pot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pot1.FormattingEnabled = true;
            this.Pot1.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.Pot1.Location = new System.Drawing.Point(475, 12);
            this.Pot1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pot1.Name = "Pot1";
            this.Pot1.Size = new System.Drawing.Size(133, 24);
            this.Pot1.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Potentiometer 1";
            // 
            // Toggle2
            // 
            this.Toggle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Toggle2.FormattingEnabled = true;
            this.Toggle2.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.Toggle2.Location = new System.Drawing.Point(475, 97);
            this.Toggle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toggle2.Name = "Toggle2";
            this.Toggle2.Size = new System.Drawing.Size(133, 24);
            this.Toggle2.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Toggle Switch 2 ";
            // 
            // Toggle1
            // 
            this.Toggle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Toggle1.FormattingEnabled = true;
            this.Toggle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Toggle1.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9"});
            this.Toggle1.Location = new System.Drawing.Point(475, 69);
            this.Toggle1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toggle1.Name = "Toggle1";
            this.Toggle1.Size = new System.Drawing.Size(133, 24);
            this.Toggle1.Sorted = true;
            this.Toggle1.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Toggle Switch 1 ";
            // 
            // JoyStick2X
            // 
            this.JoyStick2X.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JoyStick2X.FormattingEnabled = true;
            this.JoyStick2X.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.JoyStick2X.Location = new System.Drawing.Point(116, 72);
            this.JoyStick2X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoyStick2X.Name = "JoyStick2X";
            this.JoyStick2X.Size = new System.Drawing.Size(133, 24);
            this.JoyStick2X.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Joy Stick 2 X:";
            // 
            // JoyStick1X
            // 
            this.JoyStick1X.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JoyStick1X.FormattingEnabled = true;
            this.JoyStick1X.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.JoyStick1X.Location = new System.Drawing.Point(116, 12);
            this.JoyStick1X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoyStick1X.Name = "JoyStick1X";
            this.JoyStick1X.Size = new System.Drawing.Size(133, 24);
            this.JoyStick1X.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Joy Stick 1 X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Joy Stick 1 Y:";
            // 
            // JoyStick1Y
            // 
            this.JoyStick1Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JoyStick1Y.FormattingEnabled = true;
            this.JoyStick1Y.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.JoyStick1Y.Location = new System.Drawing.Point(116, 42);
            this.JoyStick1Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoyStick1Y.Name = "JoyStick1Y";
            this.JoyStick1Y.Size = new System.Drawing.Size(133, 24);
            this.JoyStick1Y.TabIndex = 85;
            // 
            // JoyStick2Y
            // 
            this.JoyStick2Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JoyStick2Y.FormattingEnabled = true;
            this.JoyStick2Y.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.JoyStick2Y.Location = new System.Drawing.Point(116, 102);
            this.JoyStick2Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoyStick2Y.Name = "JoyStick2Y";
            this.JoyStick2Y.Size = new System.Drawing.Size(133, 24);
            this.JoyStick2Y.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Joy Stick 2 Y:";
            // 
            // Btn2
            // 
            this.Btn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Btn2.FormattingEnabled = true;
            this.Btn2.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.Btn2.Location = new System.Drawing.Point(475, 153);
            this.Btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(133, 24);
            this.Btn2.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Button 2:";
            // 
            // Btn1
            // 
            this.Btn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Btn1.FormattingEnabled = true;
            this.Btn1.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9",
            "Channel 10",
            "Channel 11",
            "Channel 12",
            "Channel 13",
            "Channel 14",
            "Channel 15",
            "Channel 16"});
            this.Btn1.Location = new System.Drawing.Point(475, 125);
            this.Btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(133, 24);
            this.Btn1.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "Button 1:";
            // 
            // DroneControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 236);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JoyStick2Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JoyStick1Y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TriSwitch2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.TriSwitch1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Pot2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Pot1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Toggle2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Toggle1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.JoyStick2X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JoyStick1X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URIBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DroneControler";
            this.Text = "Drone Controler";
            this.Load += new System.EventHandler(this.DroneControler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox URIBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TriSwitch2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox TriSwitch1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox Pot2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Pot1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Toggle2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Toggle1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox JoyStick2X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JoyStick1X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox JoyStick1Y;
        private System.Windows.Forms.ComboBox JoyStick2Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Btn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Btn1;
        private System.Windows.Forms.Label label8;
    }
}


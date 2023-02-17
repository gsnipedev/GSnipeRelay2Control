namespace GSnipeRelay2Control
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RelayConnectionToggleButton = new System.Windows.Forms.Button();
            this.ToggleButtonsLay = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DevicesComboList = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.ToggleButtonsLay.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Controls.Add(this.ToggleButtonsLay);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button9);
            this.flowLayoutPanel3.Controls.Add(this.button10);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(9, 137);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(402, 102);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(399, 45);
            this.button9.TabIndex = 0;
            this.button9.Text = "Open All";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnOpenAll);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 54);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(399, 45);
            this.button10.TabIndex = 1;
            this.button10.Text = "Close All";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.OnCloseAll);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.RelayConnectionToggleButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(417, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(345, 329);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // RelayConnectionToggleButton
            // 
            this.RelayConnectionToggleButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RelayConnectionToggleButton.ForeColor = System.Drawing.Color.Red;
            this.RelayConnectionToggleButton.Location = new System.Drawing.Point(3, 3);
            this.RelayConnectionToggleButton.Name = "RelayConnectionToggleButton";
            this.RelayConnectionToggleButton.Size = new System.Drawing.Size(342, 29);
            this.RelayConnectionToggleButton.TabIndex = 0;
            this.RelayConnectionToggleButton.Text = "Relay Status : OFFLINE";
            this.RelayConnectionToggleButton.UseVisualStyleBackColor = true;
            this.RelayConnectionToggleButton.Click += new System.EventHandler(this.OnToggleRelayConnection);
            // 
            // ToggleButtonsLay
            // 
            this.ToggleButtonsLay.Controls.Add(this.button1);
            this.ToggleButtonsLay.Controls.Add(this.button2);
            this.ToggleButtonsLay.Controls.Add(this.button3);
            this.ToggleButtonsLay.Controls.Add(this.button4);
            this.ToggleButtonsLay.Controls.Add(this.button5);
            this.ToggleButtonsLay.Controls.Add(this.button6);
            this.ToggleButtonsLay.Controls.Add(this.button7);
            this.ToggleButtonsLay.Controls.Add(this.button8);
            this.ToggleButtonsLay.Location = new System.Drawing.Point(9, 58);
            this.ToggleButtonsLay.Name = "ToggleButtonsLay";
            this.ToggleButtonsLay.Size = new System.Drawing.Size(402, 73);
            this.ToggleButtonsLay.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toggle 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Toggle 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Toggle 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(303, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Toggle 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Toggle 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Toggle 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(203, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "Toggle 7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(303, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 7;
            this.button8.Text = "Toggle 8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OnToggleButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RefreshButton);
            this.flowLayoutPanel1.Controls.Add(this.DevicesComboList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(197, 29);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh Device";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DevicesComboList
            // 
            this.DevicesComboList.FormattingEnabled = true;
            this.DevicesComboList.Location = new System.Drawing.Point(206, 3);
            this.DevicesComboList.Name = "DevicesComboList";
            this.DevicesComboList.Size = new System.Drawing.Size(535, 28);
            this.DevicesComboList.TabIndex = 1;
            this.DevicesComboList.SelectedIndexChanged += new System.EventHandler(this.DevicesComboList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bantuan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 500);
            this.Name = "Form1";
            this.Text = "GSnipe Usb-Relay Controller";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ToggleButtonsLay.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button RefreshButton;
        private ComboBox DevicesComboList;
        private FlowLayoutPanel ToggleButtonsLay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button RelayConnectionToggleButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button9;
        private Button button10;
    }
}
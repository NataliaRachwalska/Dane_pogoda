namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(367, 169);
            label1.Name = "label1";
            label1.Size = new Size(72, 29);
            label1.TabIndex = 1;
            label1.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 15F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(147, 9);
            label2.Name = "label2";
            label2.Size = new Size(523, 36);
            label2.TabIndex = 2;
            label2.Text = "What's the weather like today?";
            // 
            // button1
            // 
            button1.Location = new Point(342, 321);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(261, 242);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(285, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Additional weather information";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "London,uk", "Rome,it", "Paris,fr", "Warsaw,pl", "Amsterdam,nl", "Oslo,no", "Madrid,es", "Berlin,de" });
            comboBox1.Location = new Point(275, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 33);
            comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
    }
}

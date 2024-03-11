namespace ATM
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pinErrorProvider = new ErrorProvider(components);
            withdrawButton = new Button();
            label1 = new Label();
            label2 = new Label();
            amountTextBox = new TextBox();
            pinTextBox = new TextBox();
            amountErrorProvider = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pinErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pinErrorProvider
            // 
            pinErrorProvider.ContainerControl = this;
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.Location = new Point(182, 299);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(186, 91);
            withdrawButton.TabIndex = 0;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 99);
            label1.Name = "label1";
            label1.Size = new Size(128, 29);
            label1.TabIndex = 1;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 180);
            label2.Name = "label2";
            label2.Size = new Size(66, 29);
            label2.TabIndex = 2;
            label2.Text = "Pin:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(182, 97);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(186, 31);
            amountTextBox.TabIndex = 3;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // pinTextBox
            // 
            pinTextBox.Location = new Point(182, 181);
            pinTextBox.Name = "pinTextBox";
            pinTextBox.Size = new Size(186, 31);
            pinTextBox.TabIndex = 4;
            pinTextBox.TextChanged += pinTextBox_TextChanged;
            // 
            // amountErrorProvider
            // 
            amountErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(843, 458);
            Controls.Add(pictureBox1);
            Controls.Add(pinTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(withdrawButton);
            Name = "Form1";
            Text = "ATM";
            ((System.ComponentModel.ISupportInitialize)pinErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider pinErrorProvider;
        private TextBox pinTextBox;
        private TextBox amountTextBox;
        private Label label2;
        private Label label1;
        private Button withdrawButton;
        private ErrorProvider amountErrorProvider;
        private PictureBox pictureBox1;
    }
}

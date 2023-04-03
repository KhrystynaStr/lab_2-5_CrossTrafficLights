namespace TrafficLights
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
            lampsPanel = new Panel();
            buttonManual = new Button();
            buttonAuto = new Button();
            periodGroupBox = new GroupBox();
            greenTextBox = new TextBox();
            yellowTextBox = new TextBox();
            redTextBox = new TextBox();
            buttonOk = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonExit = new Button();
            timer = new System.Windows.Forms.Timer(components);
            additionalPanel = new Panel();
            nightCheckBox = new CheckBox();
            periodGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lampsPanel
            // 
            lampsPanel.BorderStyle = BorderStyle.Fixed3D;
            lampsPanel.Location = new Point(12, 12);
            lampsPanel.Name = "lampsPanel";
            lampsPanel.Size = new Size(192, 426);
            lampsPanel.TabIndex = 0;
            lampsPanel.Paint += lampsPanel_Paint;
            // 
            // buttonManual
            // 
            buttonManual.Location = new Point(254, 12);
            buttonManual.Name = "buttonManual";
            buttonManual.Size = new Size(136, 29);
            buttonManual.TabIndex = 1;
            buttonManual.Text = "Ручне";
            buttonManual.UseVisualStyleBackColor = true;
            buttonManual.Click += buttonManual_Click;
            // 
            // buttonAuto
            // 
            buttonAuto.Location = new Point(254, 47);
            buttonAuto.Name = "buttonAuto";
            buttonAuto.Size = new Size(136, 29);
            buttonAuto.TabIndex = 2;
            buttonAuto.Text = "Автомат";
            buttonAuto.UseVisualStyleBackColor = true;
            buttonAuto.Click += buttonAuto_Click;
            // 
            // periodGroupBox
            // 
            periodGroupBox.Controls.Add(greenTextBox);
            periodGroupBox.Controls.Add(yellowTextBox);
            periodGroupBox.Controls.Add(redTextBox);
            periodGroupBox.Controls.Add(buttonOk);
            periodGroupBox.Controls.Add(label3);
            periodGroupBox.Controls.Add(label2);
            periodGroupBox.Controls.Add(label1);
            periodGroupBox.Location = new Point(254, 82);
            periodGroupBox.Name = "periodGroupBox";
            periodGroupBox.Size = new Size(136, 238);
            periodGroupBox.TabIndex = 3;
            periodGroupBox.TabStop = false;
            periodGroupBox.Text = "Тривалості";
            periodGroupBox.Visible = false;
            // 
            // greenTextBox
            // 
            greenTextBox.Location = new Point(6, 159);
            greenTextBox.Name = "greenTextBox";
            greenTextBox.Size = new Size(125, 27);
            greenTextBox.TabIndex = 2;
            greenTextBox.Text = "4";
            greenTextBox.Leave += TextBox_Leave;
            // 
            // yellowTextBox
            // 
            yellowTextBox.Location = new Point(6, 104);
            yellowTextBox.Name = "yellowTextBox";
            yellowTextBox.Size = new Size(125, 27);
            yellowTextBox.TabIndex = 1;
            yellowTextBox.Text = "2";
            yellowTextBox.Leave += TextBox_Leave;
            // 
            // redTextBox
            // 
            redTextBox.Location = new Point(6, 51);
            redTextBox.Name = "redTextBox";
            redTextBox.Size = new Size(125, 27);
            redTextBox.TabIndex = 0;
            redTextBox.Text = "3";
            redTextBox.Leave += TextBox_Leave;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(6, 203);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(124, 29);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "Гаразд";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 136);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "зелений";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "жовтий";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "червоний";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(254, 409);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(136, 29);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Завершити";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // additionalPanel
            // 
            additionalPanel.BorderStyle = BorderStyle.Fixed3D;
            additionalPanel.Location = new Point(439, 12);
            additionalPanel.Name = "additionalPanel";
            additionalPanel.Size = new Size(192, 426);
            additionalPanel.TabIndex = 5;
            additionalPanel.Paint += additionalPanel_Paint;
            // 
            // nightCheckBox
            // 
            nightCheckBox.AutoSize = true;
            nightCheckBox.Location = new Point(254, 369);
            nightCheckBox.Name = "nightCheckBox";
            nightCheckBox.Size = new Size(133, 24);
            nightCheckBox.TabIndex = 6;
            nightCheckBox.Text = "Нічний режим";
            nightCheckBox.UseVisualStyleBackColor = true;
            nightCheckBox.CheckedChanged += nightCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(nightCheckBox);
            Controls.Add(additionalPanel);
            Controls.Add(buttonExit);
            Controls.Add(periodGroupBox);
            Controls.Add(buttonAuto);
            Controls.Add(buttonManual);
            Controls.Add(lampsPanel);
            Name = "Form1";
            Text = "Світлофор";
            Load += Form1_Load;
            periodGroupBox.ResumeLayout(false);
            periodGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel lampsPanel;
        private Button buttonManual;
        private Button buttonAuto;
        private GroupBox periodGroupBox;
        private Button buttonOk;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonExit;
        private System.Windows.Forms.Timer timer;
        private TextBox greenTextBox;
        private TextBox yellowTextBox;
        private TextBox redTextBox;
        private Panel additionalPanel;
        private CheckBox nightCheckBox;
    }
}
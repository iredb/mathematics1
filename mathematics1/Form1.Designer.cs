namespace mathematics1
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
            LengthLabel = new Label();
            AEdgeLabel = new Label();
            BEdgeLabel = new Label();
            RadiusLabel = new Label();
            LTXT = new TextBox();
            aTXT = new TextBox();
            bTXT = new TextBox();
            BrickVolume = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            VolumeOutput = new Label();
            RubbishVolume = new Label();
            Rubbish = new TextBox();
            CalculateButton = new Button();
            smalllTXT = new TextBox();
            rTXT = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CylinderVolume = new TextBox();
            SuspendLayout();
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LengthLabel.Location = new Point(26, 40);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(78, 20);
            LengthLabel.TabIndex = 0;
            LengthLabel.Text = "Длина L";
            LengthLabel.Click += label1_Click;
            // 
            // AEdgeLabel
            // 
            AEdgeLabel.AutoSize = true;
            AEdgeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AEdgeLabel.Location = new Point(26, 90);
            AEdgeLabel.Name = "AEdgeLabel";
            AEdgeLabel.Size = new Size(75, 20);
            AEdgeLabel.TabIndex = 1;
            AEdgeLabel.Text = "Ребро a";
            // 
            // BEdgeLabel
            // 
            BEdgeLabel.AutoSize = true;
            BEdgeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BEdgeLabel.Location = new Point(26, 138);
            BEdgeLabel.Name = "BEdgeLabel";
            BEdgeLabel.Size = new Size(75, 20);
            BEdgeLabel.TabIndex = 2;
            BEdgeLabel.Text = "Ребро b";
            // 
            // RadiusLabel
            // 
            RadiusLabel.AutoSize = true;
            RadiusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RadiusLabel.Location = new Point(26, 186);
            RadiusLabel.Name = "RadiusLabel";
            RadiusLabel.Size = new Size(72, 20);
            RadiusLabel.TabIndex = 3;
            RadiusLabel.Text = "Длина l";
            // 
            // LTXT
            // 
            LTXT.Location = new Point(120, 40);
            LTXT.Name = "LTXT";
            LTXT.Size = new Size(100, 23);
            LTXT.TabIndex = 4;
            // 
            // aTXT
            // 
            aTXT.Location = new Point(120, 90);
            aTXT.Name = "aTXT";
            aTXT.Size = new Size(100, 23);
            aTXT.TabIndex = 5;
            // 
            // bTXT
            // 
            bTXT.Location = new Point(120, 139);
            bTXT.Name = "bTXT";
            bTXT.Size = new Size(100, 23);
            bTXT.TabIndex = 6;
            // 
            // BrickVolume
            // 
            BrickVolume.Location = new Point(209, 310);
            BrickVolume.Name = "BrickVolume";
            BrickVolume.Size = new Size(100, 23);
            BrickVolume.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(236, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "метр.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(236, 90);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "метр.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(236, 138);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 10;
            label3.Text = "метр.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(236, 186);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 11;
            label4.Text = "метр.";
            // 
            // VolumeOutput
            // 
            VolumeOutput.AutoSize = true;
            VolumeOutput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VolumeOutput.Location = new Point(27, 310);
            VolumeOutput.Name = "VolumeOutput";
            VolumeOutput.Size = new Size(140, 20);
            VolumeOutput.TabIndex = 12;
            VolumeOutput.Text = "Объем v бруска";
            VolumeOutput.Click += label5_Click;
            // 
            // RubbishVolume
            // 
            RubbishVolume.AutoSize = true;
            RubbishVolume.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RubbishVolume.Location = new Point(26, 368);
            RubbishVolume.Name = "RubbishVolume";
            RubbishVolume.Size = new Size(94, 20);
            RubbishVolume.TabIndex = 13;
            RubbishVolume.Text = "Отходы %";
            // 
            // Rubbish
            // 
            Rubbish.Location = new Point(209, 368);
            Rubbish.Name = "Rubbish";
            Rubbish.Size = new Size(100, 23);
            Rubbish.TabIndex = 14;
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalculateButton.Location = new Point(26, 457);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(266, 69);
            CalculateButton.TabIndex = 15;
            CalculateButton.Text = "ПОСЧИТАТЬ КНОПКА (МЕТР.)";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // smalllTXT
            // 
            smalllTXT.Location = new Point(120, 187);
            smalllTXT.Name = "smalllTXT";
            smalllTXT.Size = new Size(100, 23);
            smalllTXT.TabIndex = 16;
            // 
            // rTXT
            // 
            rTXT.Location = new Point(120, 237);
            rTXT.Name = "rTXT";
            rTXT.Size = new Size(100, 23);
            rTXT.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(236, 236);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 18;
            label5.Text = "метр.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(26, 236);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 17;
            label6.Text = "Радиус r";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(27, 339);
            label7.Name = "label7";
            label7.Size = new Size(167, 20);
            label7.TabIndex = 21;
            label7.Text = "Объем v цилиндра";
            // 
            // CylinderVolume
            // 
            CylinderVolume.Location = new Point(209, 339);
            CylinderVolume.Name = "CylinderVolume";
            CylinderVolume.Size = new Size(100, 23);
            CylinderVolume.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 554);
            Controls.Add(label7);
            Controls.Add(CylinderVolume);
            Controls.Add(rTXT);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(smalllTXT);
            Controls.Add(CalculateButton);
            Controls.Add(Rubbish);
            Controls.Add(RubbishVolume);
            Controls.Add(VolumeOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BrickVolume);
            Controls.Add(bTXT);
            Controls.Add(aTXT);
            Controls.Add(LTXT);
            Controls.Add(RadiusLabel);
            Controls.Add(BEdgeLabel);
            Controls.Add(AEdgeLabel);
            Controls.Add(LengthLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LengthLabel;
        private Label AEdgeLabel;
        private Label BEdgeLabel;
        private Label RadiusLabel;
        private TextBox LTXT;
        private TextBox aTXT;
        private TextBox bTXT;
        private TextBox BrickVolume;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label VolumeOutput;
        private Label RubbishVolume;
        private TextBox Rubbish;
        private Button CalculateButton;
        private TextBox smalllTXT;
        private TextBox rTXT;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox CylinderVolume;
    }
}

namespace StrengthCalculator
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
            infoLabel = new Label();
            weightTotal = new TextBox();
            label1 = new Label();
            squatTotal = new TextBox();
            benchTotal = new TextBox();
            deadliftTotal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            calculateButton = new Button();
            label5 = new Label();
            result = new Label();
            label6 = new Label();
            dotsLabel = new Label();
            maleButton = new RadioButton();
            femaleButton = new RadioButton();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.Location = new Point(12, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(346, 38);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Please enter your details:";
            infoLabel.Click += label1_Click_1;
            // 
            // weightTotal
            // 
            weightTotal.BorderStyle = BorderStyle.FixedSingle;
            weightTotal.Location = new Point(199, 66);
            weightTotal.Name = "weightTotal";
            weightTotal.Size = new Size(125, 27);
            weightTotal.TabIndex = 1;
            weightTotal.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 68);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 2;
            label1.Text = "Body Weight (kgs)";
            label1.Click += label1_Click_2;
            // 
            // squatTotal
            // 
            squatTotal.BorderStyle = BorderStyle.FixedSingle;
            squatTotal.Location = new Point(199, 126);
            squatTotal.Name = "squatTotal";
            squatTotal.Size = new Size(125, 27);
            squatTotal.TabIndex = 3;
            squatTotal.TextChanged += squatTotal_TextChanged;
            // 
            // benchTotal
            // 
            benchTotal.BorderStyle = BorderStyle.FixedSingle;
            benchTotal.Location = new Point(199, 186);
            benchTotal.Name = "benchTotal";
            benchTotal.Size = new Size(125, 27);
            benchTotal.TabIndex = 4;
            benchTotal.TextChanged += benchTotal_TextChanged;
            // 
            // deadliftTotal
            // 
            deadliftTotal.BorderStyle = BorderStyle.FixedSingle;
            deadliftTotal.Location = new Point(199, 246);
            deadliftTotal.Name = "deadliftTotal";
            deadliftTotal.Size = new Size(125, 27);
            deadliftTotal.TabIndex = 5;
            deadliftTotal.TextChanged += deadliftTotal_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 128);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Squat (kgs)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 188);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Bench (kgs)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 248);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 8;
            label4.Text = "Deadlifts (kgs)";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(112, 337);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(133, 59);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(471, 126);
            label5.Name = "label5";
            label5.Size = new Size(73, 31);
            label5.TabIndex = 10;
            label5.Text = "Total:";
            label5.Click += label5_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(568, 133);
            result.Name = "result";
            result.Size = new Size(37, 20);
            result.TabIndex = 11;
            result.Text = "0 kg";
            result.Click += result_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(471, 188);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 14;
            label6.Text = "DOTS: ";
            label6.Click += label6_Click;
            // 
            // dotsLabel
            // 
            dotsLabel.AutoSize = true;
            dotsLabel.Location = new Point(566, 187);
            dotsLabel.Name = "dotsLabel";
            dotsLabel.Size = new Size(17, 20);
            dotsLabel.TabIndex = 15;
            dotsLabel.Text = "0";
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Location = new Point(91, 291);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(63, 24);
            maleButton.TabIndex = 16;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            maleButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Location = new Point(199, 291);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(78, 24);
            femaleButton.TabIndex = 17;
            femaleButton.TabStop = true;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            femaleButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(femaleButton);
            Controls.Add(maleButton);
            Controls.Add(dotsLabel);
            Controls.Add(label6);
            Controls.Add(result);
            Controls.Add(label5);
            Controls.Add(calculateButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deadliftTotal);
            Controls.Add(benchTotal);
            Controls.Add(squatTotal);
            Controls.Add(label1);
            Controls.Add(weightTotal);
            Controls.Add(infoLabel);
            Name = "Form1";
            Text = "Strength Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private TextBox weightTotal;
        private Label label1;
        private TextBox squatTotal;
        private TextBox benchTotal;
        private TextBox deadliftTotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button calculateButton;
        private Label label5;
        private Label result;
        private Label label6;
        private Label dotsLabel;
        private RadioButton maleButton;
        private RadioButton femaleButton;
    }
}
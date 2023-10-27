namespace Lab3
{
	partial class Form1
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
			this.drawButton = new System.Windows.Forms.Button();
			this.speedTrackBar = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.iterationInput = new System.Windows.Forms.NumericUpDown();
			this.S_Input = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.F_Input = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.angleInput = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.X_Input = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Y_Input = new System.Windows.Forms.TextBox();
			this.fractalChoiceComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iterationInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.angleInput)).BeginInit();
			this.SuspendLayout();
			// 
			// drawButton
			// 
			this.drawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.drawButton.Location = new System.Drawing.Point(46, 458);
			this.drawButton.Name = "drawButton";
			this.drawButton.Size = new System.Drawing.Size(97, 40);
			this.drawButton.TabIndex = 0;
			this.drawButton.Text = "Draw";
			this.drawButton.UseVisualStyleBackColor = true;
			this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
			// 
			// speedTrackBar
			// 
			this.speedTrackBar.Location = new System.Drawing.Point(114, 86);
			this.speedTrackBar.Maximum = 3;
			this.speedTrackBar.Minimum = 1;
			this.speedTrackBar.Name = "speedTrackBar";
			this.speedTrackBar.Size = new System.Drawing.Size(146, 45);
			this.speedTrackBar.TabIndex = 1;
			this.speedTrackBar.Value = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(42, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Iterations";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(42, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Speed";
			// 
			// iterationInput
			// 
			this.iterationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iterationInput.Location = new System.Drawing.Point(132, 134);
			this.iterationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.iterationInput.Name = "iterationInput";
			this.iterationInput.Size = new System.Drawing.Size(128, 29);
			this.iterationInput.TabIndex = 3;
			this.iterationInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// S_Input
			// 
			this.S_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.S_Input.Location = new System.Drawing.Point(91, 190);
			this.S_Input.Name = "S_Input";
			this.S_Input.Size = new System.Drawing.Size(169, 23);
			this.S_Input.TabIndex = 4;
			this.S_Input.Text = "F-X-X";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(42, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "S = ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(42, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "F = ";
			// 
			// F_Input
			// 
			this.F_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.F_Input.Location = new System.Drawing.Point(91, 233);
			this.F_Input.Name = "F_Input";
			this.F_Input.Size = new System.Drawing.Size(169, 23);
			this.F_Input.TabIndex = 4;
			this.F_Input.Text = "F-X+F+X-F";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(42, 364);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 24);
			this.label5.TabIndex = 2;
			this.label5.Text = "angle = ";
			// 
			// angleInput
			// 
			this.angleInput.DecimalPlaces = 1;
			this.angleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.angleInput.Location = new System.Drawing.Point(132, 364);
			this.angleInput.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
			this.angleInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.angleInput.Name = "angleInput";
			this.angleInput.Size = new System.Drawing.Size(128, 29);
			this.angleInput.TabIndex = 3;
			this.angleInput.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(42, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 24);
			this.label6.TabIndex = 2;
			this.label6.Text = "X = ";
			// 
			// X_Input
			// 
			this.X_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.X_Input.Location = new System.Drawing.Point(91, 275);
			this.X_Input.Name = "X_Input";
			this.X_Input.Size = new System.Drawing.Size(169, 23);
			this.X_Input.TabIndex = 4;
			this.X_Input.Text = "XX";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(42, 321);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 24);
			this.label7.TabIndex = 2;
			this.label7.Text = "Y = ";
			// 
			// Y_Input
			// 
			this.Y_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Y_Input.Location = new System.Drawing.Point(91, 321);
			this.Y_Input.Name = "Y_Input";
			this.Y_Input.Size = new System.Drawing.Size(169, 23);
			this.Y_Input.TabIndex = 4;
			// 
			// fractalChoiceComboBox
			// 
			this.fractalChoiceComboBox.FormattingEnabled = true;
			this.fractalChoiceComboBox.Location = new System.Drawing.Point(46, 417);
			this.fractalChoiceComboBox.Name = "fractalChoiceComboBox";
			this.fractalChoiceComboBox.Size = new System.Drawing.Size(214, 21);
			this.fractalChoiceComboBox.TabIndex = 5;
			this.fractalChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.fractalChoiceComboBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 607);
			this.Controls.Add(this.fractalChoiceComboBox);
			this.Controls.Add(this.F_Input);
			this.Controls.Add(this.Y_Input);
			this.Controls.Add(this.X_Input);
			this.Controls.Add(this.S_Input);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.angleInput);
			this.Controls.Add(this.iterationInput);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.speedTrackBar);
			this.Controls.Add(this.drawButton);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iterationInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.angleInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button drawButton;
		private System.Windows.Forms.TrackBar speedTrackBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown iterationInput;
		private System.Windows.Forms.TextBox S_Input;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox F_Input;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown angleInput;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox X_Input;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Y_Input;
		private System.Windows.Forms.ComboBox fractalChoiceComboBox;
	}
}


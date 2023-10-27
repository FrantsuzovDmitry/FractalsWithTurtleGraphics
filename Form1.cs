using System;
using System.Windows.Forms;

namespace Lab3
{
	public partial class Form1 : Form
	{
		private MyTurtle _myTurtle;

		public Form1()
		{
			InitializeComponent();
			_myTurtle = new MyTurtle();
			InitializeFractalChoices();
		}

		private void drawButton_Click(object sender, EventArgs e)
		{
			InitializeTurtle();

			_myTurtle.Run();
		}

		private void InitializeTurtle()
		{
			// Parameters initialization
			var iterations = (int)iterationInput.Value;
			var speed = speedTrackBar.Value;
			var initialRule = S_Input.Text;
			var F_Rule = F_Input.Text;
			var X_Rule = X_Input.Text;
			var Y_Rule = Y_Input.Text;
			var rotationAngle = (float)angleInput.Value;

			_myTurtle.InitializeTurtle(speed, iterations,
								initialRule, F_Rule, X_Rule, Y_Rule, rotationAngle);
		}

		private void InitializeFractalChoices()
		{
			fractalChoiceComboBox.Items.Add("Снежинка Коха");
			fractalChoiceComboBox.Items.Add("Треугольник Серпинского");
			fractalChoiceComboBox.Items.Add("Стреловидная кривая Серпинского");
			fractalChoiceComboBox.Items.Add("Дракон Хартера-Хатвея");
			fractalChoiceComboBox.Items.Add("Дерево 1");
			fractalChoiceComboBox.Items.Add("Дерево 2");
			fractalChoiceComboBox.Items.Add("Дерево 3");
			fractalChoiceComboBox.Items.Add("Фрактальное дерево 7");

			fractalChoiceComboBox.SelectedIndex = 0;
		}

		/// <summary>
		/// Autocomplete the rules
		/// </summary>
		private void fractalChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (fractalChoiceComboBox.Text)
			{
				case "Треугольник Серпинского":
					S_Input.Text = "F-X-X";
					F_Input.Text = "F-X+F+X-F";
					X_Input.Text = "XX";
					Y_Input.Text = "";
					angleInput.Value = 120;
					break;
				case "Снежинка Коха":
					S_Input.Text = "F++F++F";
					F_Input.Text = "F-F++F-F";
					X_Input.Text = "";
					Y_Input.Text = "";
					angleInput.Value = 60;
					break;
				case "Стреловидная кривая Серпинского":
					S_Input.Text = "F";
					F_Input.Text = "X-F-X";
					X_Input.Text = "F+X+F";
					Y_Input.Text = "";
					angleInput.Value = 60;
					break;
				case "Дракон Хартера-Хатвея":
					S_Input.Text = "FX";
					F_Input.Text = "F";
					X_Input.Text = "X+YF+";
					Y_Input.Text = "-FX-Y";
					angleInput.Value = 90;
					break;
				case "Дерево 1":
					S_Input.Text = "F";
					F_Input.Text = "F[+F]F[-F]F";
					X_Input.Text = "";
					Y_Input.Text = "";
					angleInput.Value = (decimal)25.7;
					break;
				case "Дерево 2":
					S_Input.Text = "F";
					F_Input.Text = "F[+F]F[-F][F]";
					X_Input.Text = "";
					Y_Input.Text = "";
					angleInput.Value = 20;
					break;
				case "Дерево 3":
					S_Input.Text = "X";
					F_Input.Text = "FF";
					X_Input.Text = "F[+X][-X]FX";
					Y_Input.Text = "";
					angleInput.Value = 25;
					break;
				case "Фрактальное дерево 7":
					S_Input.Text = "X";
					F_Input.Text = "FF";
					X_Input.Text = "F-[[X]+X]+F[+FX]-X";
					Y_Input.Text = "";
					angleInput.Value = 20;
					break;
			}
		}
	}
}

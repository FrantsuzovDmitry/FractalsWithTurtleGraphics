using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
	internal class MyTurtle
	{
		private string S_rule;   // initial rule
		private string F_rule;   // movement rule
		private string X_rule;   // movement rule
		private string Y_rule;   // movement rule
		private Dictionary<char, Action> Rules = new Dictionary<char, Action>();
		private Dictionary<char, Action<int>> RecursiveRules = new Dictionary<char, Action<int>>();

		private float _rotationAngle = 90;
		private int _iterations = 1;
		private int _lineLenght = DefaultLineLenght;

		private const int DefaultLineLenght = 30;
		private const int MinLineLenght = 2;
		private const int DefaultTurtleDelay = 50;

		#region Function of turtle move definition
		public MyTurtle()
		{
			Rules['b'] = Backward;
			Rules['['] = RememberState;
			Rules[']'] = SetRememberedState;
			Rules['+'] = RotateClockwise;
			Rules['-'] = RotateCounterClockwise;
			Rules['–'] = RotateCounterClockwise;

			RecursiveRules['F'] = F;
			RecursiveRules['X'] = X;
			RecursiveRules['Y'] = Y;
		}

		private void Forward() => Turtle.Forward(_lineLenght);

		private void Backward()
		{
			Turtle.PenUp();
			Turtle.Backward(10);
			Turtle.PenDown();
		}

		private void RememberState()
		{
			this.PushState(Turtle.X, Turtle.Y, Turtle.Angle);
		}

		private void SetRememberedState()
		{
			var state = this.PopState();
			Turtle.X = state.X;
			Turtle.Y = state.Y;
			Turtle.Angle = state.Angle;
		}

		private void RotateClockwise()
		{
			Turtle.Rotate(_rotationAngle);
		}

		private void RotateCounterClockwise()
		{
			Turtle.Rotate(-_rotationAngle);
		}
		#endregion

		public void InitializeTurtle(int speed, int iterations,
									string S, string F, string X, string Y, float angle)
		{
			Turtle.Reset();
			SelectTurtleDelay(speed, iterations);

			Turtle.PenUp();
			Turtle.MoveTo(-25 * iterations, -25 * iterations);
			Turtle.PenDown();
			Turtle.Angle = 0;

			SelectLineLength(iterations);

			Turtle.PenSize = 2;
			Turtle.ShowTurtle = false;

			InitializeParameters(iterations, S, F, X, Y, angle);
		}

		private void SelectLineLength(int iterations)
		{
			if (iterations > 2)
				_lineLenght = DefaultLineLenght * 2 / iterations / iterations;
			else
				_lineLenght = DefaultLineLenght;
			if (_lineLenght < 2) _lineLenght = MinLineLenght;
		}

		private static void SelectTurtleDelay(int speed, int iterations)
		{
			switch (speed)
			{
				case 2:
					// 2nd speed - the more iterations, the faster
					Turtle.Delay = DefaultTurtleDelay / (iterations * 10);
					if (Turtle.Delay < 1)
						Turtle.Delay = 1;
					break;
				case 3:
					// 3rd speed - very fast
					Turtle.Delay = 0;
					break;
				default:
					// 1st speed - const delay
					Turtle.Delay = DefaultTurtleDelay;
					break;
			}
		}

		private void InitializeParameters(int iterations, string S, string F, string X, string Y, float angle)
		{
			// Validation of data
			StringBuilder sb = new StringBuilder();
			var collection = new string[4] { S, F, X, Y };
			var correctCollection = new List<string>();

			foreach (var str in collection)
			{
				sb.Clear();
				foreach (var c in str)
				{
					if (Rules.ContainsKey(c) || RecursiveRules.ContainsKey(c))
						sb.Append(c);
				}
				correctCollection.Add(sb.ToString());
			}

			S_rule = correctCollection[0];
			F_rule = correctCollection[1];
			X_rule = correctCollection[2];
			Y_rule = correctCollection[3];
			_rotationAngle = angle;
			_iterations = iterations;
		}

		private bool IsRecursiveRule(char rule)
		{
			return rule == 'F' || rule == 'X' || rule == 'Y';
		}

		public void Run()
		{
			var n = _iterations;
			foreach (var rule in S_rule)
			{
				if (IsRecursiveRule(rule))
					RecursiveRules[rule](_iterations);
				else
					Rules[rule]();
			}
		}

		private void F(int n)
		{
			if (n == 0) Forward();
			else
			{
				n--;
				foreach (var rule in F_rule)
				{
					if (IsRecursiveRule(rule))
						RecursiveRules[rule](n);
					else
						Rules[rule]();
				}
			}
		}

		private void X(int n)
		{
			if (n == 0) Forward();
			else
			{
				n--;
				foreach (var rule in X_rule)
				{
					if (IsRecursiveRule(rule))
						RecursiveRules[rule](n);
					else
						Rules[rule]();
				}
			}
		}

		private void Y(int n)
		{
			if (n == 0) Forward();
			else
			{
				n--;
				foreach (var rule in Y_rule)
				{
					if (IsRecursiveRule(rule))
						RecursiveRules[rule](n);
					else
						Rules[rule]();
				}
			}
		}

		internal void Dispose()
		{
			Turtle.Init();
		}
	}
}

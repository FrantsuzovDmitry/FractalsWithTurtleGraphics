using System.Collections.Generic;

namespace Lab3
{
	internal class TurtleState
	{
		public float X { get; }
		public float Y { get; }
		public float Angle { get; }

		public TurtleState(float x, float y, float angle)
		{
			X = x;
			Y = y;
			Angle = angle;
		}
	}

	internal static class TurtleGraphicsExtension
	{
		private static readonly Stack<TurtleState> StateStack = new Stack<TurtleState>();

		public static void PushState(this MyTurtle turtle, float x, float y, float angle)
		{
			StateStack.Push(new TurtleState(x, y, angle));
		}

		public static TurtleState PopState(this MyTurtle turtle)
		{
			if (StateStack.Count > 0) { return StateStack.Pop(); }
			else { return null; }
		}
	}
}

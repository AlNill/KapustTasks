using System;

class Program
{
	struct IntValue
	{
		public int? Value;

		public bool HasValue
        {
			get { return Value != null; }
        }
	}

	static void Main(string[] args)
	{
		IntValue intValue = new IntValue();
		Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

		intValue.Value = 1;
		Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

		intValue.Value = -1;
		Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

		intValue.Value = 0;
		Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

		intValue.Value = null;
		Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

		Console.ReadKey();
	}
}

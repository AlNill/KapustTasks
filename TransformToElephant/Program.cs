using System;

class Program
{
	static void Main(string[] args)
	{
		TransformToElephant();
		Console.WriteLine("Fly");
		//... custom application code
	}

	static void TransformToElephant()
	{
		string el = "Elephant";
		if (Console.Out.NewLine != el)
        {
			Console.WriteLine(el);
			Console.SetOut(new StringWriter() { NewLine = "" });
		}
	}
}
using System;
class Program
{
	static void Main(string[] args)
	{
		try
		{
			FailProcess();
		}
		catch { }

		Console.WriteLine("Failed to fail process!");
		Console.ReadKey();
	}

	static void FailProcess()
	{
		Console.WriteLine("If you see only this text - success fail process!");
		Environment.Exit(0);
	}
}
using System;

public class Starter
{
	internal void Run()
	{
		int ranLog;
		Logger logger = Logger.getIns();
		Result result = new Result();
		Random random = new Random();
		Actions actions = new Actions();
		for (int i = 0; i < 100; i++)
		{
			ranLog = random.Next(1, 3);
			switch (ranLog)
			{
				case 1:
					result = actions.Info();
					break;
				case 2:
					Console.WriteLine("Action got this custom Exception: ");
					result = actions.BusinessException();
					break;
				case 3:
					Console.WriteLine("Action failed by reason: ");
					result = actions.Exception();
					break;
			}
		}

		logger.WriteToFile();


	}
}


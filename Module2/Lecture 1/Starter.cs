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
					result = actions.InputInfo();
					break;
				case 2:
					result = actions.InputWarning();
					break;
				case 3:
					result = actions.InputError();
					break;
			}
		}

		logger.WriteToFile();


	}
}



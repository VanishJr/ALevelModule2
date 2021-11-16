namespace Lecture1
{
    class Starter
    {
        internal void Run()
        {
            Logger logger = Logger.getInstance();
            int r;
            Actions actions = new Actions();
            Random random = new Random(); 
            Result res = new Result();
            for (int i = 0; i < 100; i++)
            {
                r = random.Next(1, 4);
                switch (r)
                {
                    case 1:
                        res = actions.Info();
                        break;
                    case 2:
                        res = actions.Warning();
                        break;
                    case 3:
                        res = actions.Error();
                        break;
                }

                if (!res.Status)
                {
                    logger.Add(Logger.TypeLog.Error, "Failed: " + res.ErrorMessage);
                }
            }

            logger.WriteToFile();

        }
    }
}

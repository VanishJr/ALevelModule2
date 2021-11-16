using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    class Actions
    {
        Logger logger = Logger.getInstance();
        Result result = new Result();

        public Result Info()
        {
            result.ErrorMessage = $"Start: @Info@";
            result.Status = true;
            logger.Add(Logger.TypeLog.Info, result.ErrorMessage);
            return result;
        }

        public Result Warning()
        {
            result.ErrorMessage = $"Skipped logic: @Warning@";
            result.Status = true;
            logger.Add(Logger.TypeLog.Warning, result.ErrorMessage);
            return result;
        }

        public Result Error()
        {
            result.ErrorMessage = "Oops, it's broken";
            result.Status = false;
            return result;
        }
    }
}

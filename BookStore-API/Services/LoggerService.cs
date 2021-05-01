using BookStore_API.Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class LoggerService : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            logger.Error(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}

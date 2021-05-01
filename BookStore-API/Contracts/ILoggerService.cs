using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void LogInfo(string message);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void LogWarn(string message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void LogDebug(string message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void LogError(string message);
    }
}

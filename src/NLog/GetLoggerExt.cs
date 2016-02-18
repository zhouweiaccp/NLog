using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog
{
    /// <summary>
    /// GetLogger with current classname
    /// </summary>
    public static class GetLoggerExt
    {
        /// <summary>
        /// Get logger for current class.
        /// </summary>
        /// <example>
        /// this.GetCurrentClassLogger();
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="current"></param>
        /// <returns></returns>
        /// <remarks>Without stackframes</remarks>
        [CLSCompliant(false)]
        public static ILogger GetCurrentClassLogger<T>(this T current)
            where T: class 
        {
            return LogManager.GetLogger(typeof(T).FullName);
        }

        /// <summary>
        /// Get logger for current class.
        /// </summary>
        /// <example>
        /// this.GetCurrentClassLogger();
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <remarks>Without stackframes</remarks>
        [CLSCompliant(false)]
        public static ILogger GetCurrentClassLogger<T>()
            where T : class
        {
            return LogManager.GetLogger(typeof(T).FullName);
        }

        /// <summary>
        /// Get logger for current class.
        /// </summary>
        /// <example>
        /// this.GetCurrentClassLogger();
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="current"></param>
        /// <param name="loggerName">name of the logger</param>
        /// <returns></returns>
        /// <remarks>Without stackframes</remarks>
        [CLSCompliant(false)]
        public static ILogger GetLogger<T>(this T current, string loggerName)
            where T : class
        {
            return LogManager.GetLogger(loggerName);
        }
    }
}

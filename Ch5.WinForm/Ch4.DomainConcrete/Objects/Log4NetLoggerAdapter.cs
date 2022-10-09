using Ch5.DomainIF.Objects;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5.DomainConcrete.Objects
{
    /// <summary>
    /// アダプター
    /// </summary>
    internal class Log4NetLoggerAdapter : ILogger
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(SimpleTradeValidator));

        public void LogError(string message, params object[] args)
        {
            _log.Info(string.Format(message, args));
        }

        public void LogInfo(string message, params object[] args)
        {
            _log.Info(string.Format(message, args));
        }

        public void LogWarning(string message, params object[] args)
        {
            _log.Info(string.Format(message, args));
        }
    }
}

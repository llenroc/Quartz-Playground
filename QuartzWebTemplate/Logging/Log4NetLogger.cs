﻿using System;
using System.Diagnostics;
using Common.Logging;
using Common.Logging.Factory;
using log4net.Core;

namespace QuartzWebTemplate.Logging
{
    /// <summary>
    /// Concrete implementation of <see cref="ILog"/> interface specific to log4net 1.2.10.
    /// </summary>
    /// <remarks>
    /// Log4net is capable of outputting extended debug information about where the current 
    /// message was generated: class name, method name, file, line, etc. Log4net assumes that the location
    /// information should be gathered relative to where Debug() was called. 
    /// When using Common.Logging, Debug() is called in Common.Logging.Log4Net.Log4NetLogger. This means that
    /// the location information will indicate that Common.Logging.Log4Net.Log4NetLogger always made
    /// the call to Debug(). We need to know where Common.Logging.ILog.Debug()
    /// was called. To do this we need to use the log4net.ILog.Logger.Log method and pass in a Type telling
    /// log4net where in the stack to begin looking for location information.
    /// </remarks>
    /// <author>Gilles Bayon</author>
    /// <author>Erich Eichinger</author>
    public class Log4NetLogger : AbstractLogger
    {
        #region Fields

        private readonly ILogger _logger;
        private static Type callerStackBoundaryType;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="log"></param>
        internal protected Log4NetLogger(ILoggerWrapper log)
        {
            _logger = log.Logger;
        }

        #region ILog Members

        /// <summary>
        /// Checks if this logger is enabled for the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
        /// </summary>
        public override bool IsTraceEnabled
        {
            get { return _logger.IsEnabledFor(Level.Trace); }
        }

        /// <summary>
        /// Checks if this logger is enabled for the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
        /// </summary>
        public override bool IsDebugEnabled
        {
            get { return _logger.IsEnabledFor(Level.Debug); }
        }

        /// <summary>
        /// Checks if this logger is enabled for the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        public override bool IsInfoEnabled
        {
            get { return _logger.IsEnabledFor(Level.Info); }
        }

        /// <summary>
        /// Checks if this logger is enabled for the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        public override bool IsWarnEnabled
        {
            get { return _logger.IsEnabledFor(Level.Warn); }
        }

        /// <summary>
        /// Checks if this logger is enabled for the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        public override bool IsErrorEnabled
        {
            get { return _logger.IsEnabledFor(Level.Error); }
        }

        /// <summary>
        /// Checks if this logger is enabled for the <see cref="F:Common.Logging.LogLevel.Fatal" /> level.
        /// </summary>
        public override bool IsFatalEnabled
        {
            get { return _logger.IsEnabledFor(Level.Fatal); }
        }

        /// <summary>
        /// Sends the message to the underlying log4net system.
        /// </summary>
        /// <param name="logLevel">the level of this log event.</param>
        /// <param name="message">the message to log</param>
        /// <param name="exception">the exception to log (may be null)</param>
        protected override void WriteInternal(LogLevel logLevel, object message, Exception exception)
        {
            // determine correct caller - this might change due to jit optimizations with method inlining
            if (callerStackBoundaryType == null)
            {
                lock (this.GetType())
                {
                    StackTrace stack = new StackTrace();
                    Type thisType = this.GetType();
                    callerStackBoundaryType = typeof(AbstractLogger);
                    for (int i = 1; i < stack.FrameCount; i++)
                    {
                        if (!IsInTypeHierarchy(thisType, stack.GetFrame(i).GetMethod().DeclaringType))
                        {
                            callerStackBoundaryType = stack.GetFrame(i - 1).GetMethod().DeclaringType;
                            break;
                        }
                    }
                }
            }

            Level level = GetLevel(logLevel);
            _logger.Log(callerStackBoundaryType, level, message, exception);
        }

        private bool IsInTypeHierarchy(Type currentType, Type checkType)
        {
            while (currentType != null && currentType != typeof(object))
            {
                if (currentType == checkType)
                {
                    return true;
                }
                currentType = currentType.BaseType;
            }
            return false;
        }

        /// <summary>
        /// Maps <see cref="LogLevel"/> to log4net's <see cref="Level"/>
        /// </summary>
        /// <param name="logLevel"></param>
        public static Level GetLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.All:
                    return Level.All;
                case LogLevel.Trace:
                    return Level.Trace;
                case LogLevel.Debug:
                    return Level.Debug;
                case LogLevel.Info:
                    return Level.Info;
                case LogLevel.Warn:
                    return Level.Warn;
                case LogLevel.Error:
                    return Level.Error;
                case LogLevel.Fatal:
                    return Level.Fatal;
                default:
                    throw new ArgumentOutOfRangeException("logLevel", logLevel, "unknown log level");
            }
        }

        /// <summary>
        /// Returns the global context for variables
        /// </summary>
        public override IVariablesContext GlobalVariablesContext
        {
            get { return new Log4NetGlobalVariablesContext(); }
        }

        /// <summary>
        /// Returns the thread-specific context for variables
        /// </summary>
        public override IVariablesContext ThreadVariablesContext
        {
            get { return new Log4NetThreadVariablesContext(); }
        }

        #endregion
    }
}
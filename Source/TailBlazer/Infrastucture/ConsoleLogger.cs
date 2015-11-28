﻿using System;
using TailBlazer.Domain.Infrastructure;

namespace TailBlazer.Infrastucture
{
    public class NullLogger : ILogger
    {
        public void Debug(string message, params object[] values)
        {

        }

        public void Info(string message, params object[] values)
        {

        }

        public void Warn(string message, params object[] values)
        {

        }

        public void Error(Exception ex, string message, params object[] values)
        {

        }

        public void Fatal(string message, params object[] values)
        {

        }
    }
}
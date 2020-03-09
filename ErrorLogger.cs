﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNikola
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrEmpty(error))
            {
                throw new ArgumentNullException();
            }
            LastError = error;

            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}

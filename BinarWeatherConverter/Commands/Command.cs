﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BinarWeatherConverter.Commands
{
    public class Command : ICommand
    {
        private Action ToExecute;
        private Action<object> ToExecuteObject;
        public event EventHandler? CanExecuteChanged;

        public Command(Action toExecute)
        {
            ToExecute = toExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            ToExecute?.Invoke();
            ToExecuteObject?.Invoke(parameter);
        }
    }
}

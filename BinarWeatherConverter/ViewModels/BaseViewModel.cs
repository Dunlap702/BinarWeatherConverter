using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BinarWeatherConverter.ViewModels
{
    public interface IEvaluate
    {
        public void Evaluate(string[] data);
        public object? WorstCase();
    }
    public abstract class BaseViewModel : IEvaluate
    {
        public virtual void Evaluate(string[] data) { }

        public virtual void Evaluate(string data, bool isItem) { }

        public virtual object? WorstCase()
        {
            return null;
        }
    }
}

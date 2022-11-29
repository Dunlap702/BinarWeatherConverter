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

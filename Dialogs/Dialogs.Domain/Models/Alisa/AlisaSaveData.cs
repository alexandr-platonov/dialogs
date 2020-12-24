namespace Dialogs.Domain.Models.Alisa
{
    public class AlisaSaveData<T>
    {
        public AlisaSaveData(T value)
        {
            Value = value;
        }

        public T Value { get; }
    }
}
namespace ConsoleUI
{
    public interface IObserver
    {
        //State values the observer will get from the observer when the weather measurement changes
        //This will be implemented by all observers which will implement the update() method.
        public void Update(float temp, float humidity, float pressure);
    }
}
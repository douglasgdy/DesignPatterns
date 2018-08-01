namespace DesignPatterns.Structural.Facade
{
    public interface IStorage
    {
        void Add(int id, string message);
        string Get(int id);
        void Remove(int id);
    }
}
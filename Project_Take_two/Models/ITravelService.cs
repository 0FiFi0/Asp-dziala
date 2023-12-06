namespace Project_Take_two.Models
{
    public interface ITravelService
    {
        int Add(Travel trip);
        void Delete(int id);
        void Update(Travel trip);
        List<Travel> FindAll();
        Travel? FindById(int id);
        int Count();
    }
}

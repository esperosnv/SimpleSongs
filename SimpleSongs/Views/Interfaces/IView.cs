
namespace SimpleSongs.Views.Interfaces
{
    public interface  IView<T>
    {
        public void DisplayAll(List<T> entities);
        void DisplaySingle(T entity);
    }
}

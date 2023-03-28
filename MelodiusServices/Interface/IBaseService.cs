namespace MelodiusServices.Interface
{
    public interface IBaseService<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public int AddNew(T baseDto);
        public T Update(T baseDto);
        public int Delete(int id);
    }
}

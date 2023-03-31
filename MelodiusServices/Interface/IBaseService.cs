namespace MelodiusServices.Interface
{
    public interface IBaseService<T>
    {
        public Task < List<T>> GetAll();
        public T GetById(int id);
        public Task <int> AddNew(T baseDto);
        public T Update(T baseDto);
        public Task<int> Delete(int id);
    }
}

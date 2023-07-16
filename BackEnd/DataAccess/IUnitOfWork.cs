using BackEnd.DataBase;

namespace BackEnd.DataAccess
{
    public interface IUnitOfWork
    {
        Task Complete();
    }

    public class UnitOfWork : IUnitOfWork, IAutomaticImplementation
    {
        private readonly DBTestBGContext context;

        public UnitOfWork(DBTestBGContext context)
        {
            this.context = context;
        }

        public async Task Complete()
        {
            await context.SaveChangesAsync();
        }
    }
}

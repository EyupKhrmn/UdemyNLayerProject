using System.Threading.Tasks;

namespace UdemyNlayerProject.CORE.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        void Commit();
    }
}
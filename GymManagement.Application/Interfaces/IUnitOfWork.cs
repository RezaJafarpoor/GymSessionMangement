namespace GymManagement.Application.Interfaces;

public interface IUnitOfWork
{
    Task CommitChangesAsync();
}
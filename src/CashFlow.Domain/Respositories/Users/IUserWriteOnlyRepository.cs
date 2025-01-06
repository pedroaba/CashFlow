namespace CashFlow.Domain.Respositories.Users;
public interface IUserWriteOnlyRepository
{
    Task Add(Entities.User user);
}

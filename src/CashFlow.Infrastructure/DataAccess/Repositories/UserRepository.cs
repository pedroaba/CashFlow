using CashFlow.Domain.Entities;
using CashFlow.Domain.Respositories.Users;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess.Repositories;
internal class UserRepository : IUserReadOnlyRepository, IUserWriteOnlyRepository
{
    private readonly CashFlowDbContext _context;
    public UserRepository(CashFlowDbContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistActiveUserWithEmail(string email)
    {
        return await _context.Users.AnyAsync(u => u.Email.Equals(email));
    }

    public async Task Add(User user)
    {
        await _context.Users.AddAsync(user);
    }
}

using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Respositories.Expenses;
public interface IExpensesWriteOnlyRepository
{
    public Task Add(Expense expense);
    /// <summary>
    /// This function returns TRUE if the deletition was successful otherwise FALSE
    /// </summary>
    /// <param name="id">Id of expense</param>
    /// <returns></returns>
    public Task<bool> Delete(long id);
}

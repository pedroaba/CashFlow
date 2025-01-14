﻿using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Respositories.Expenses;
public interface IExpensesReadOnlyRepository
{
    public Task<List<Expense>> GetAll();
    public Task<Expense?> GetById(long id);
    public Task<List<Expense>> FilterByMonth(DateTime startDate, DateTime endDate);
}

﻿using CashFlow.Domain.Respositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf;
public interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly date);
}

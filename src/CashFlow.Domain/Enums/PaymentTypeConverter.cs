using CashFlow.Domain.Reports;

namespace CashFlow.Domain.Enums;
public static class PaymentTypeConverter
{
    public static string Translate(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.CreditCard => ResourceReportGenerationMessages.CREDIT_CARD,
            PaymentType.DebitCard => ResourceReportGenerationMessages.DEBIT_CARD,
            PaymentType.Cash => ResourceReportGenerationMessages.CASH,
            PaymentType.EletronicTransfer => ResourceReportGenerationMessages.ELECTRONIC_TRANSFER,
            _ => string.Empty
        };
    }
}

﻿using System.Net;

namespace CashFlow.Exception.ExceptionsBase;
public class ErrorOnValidationException : CashFlowException
{
    private readonly List<string> _errors;

    public override int StatusCode => (int)HttpStatusCode.BadRequest;

    public ErrorOnValidationException(List<string> errorMessages) : base(string.Empty)
    {
        this._errors = errorMessages;
    }

    public override List<string> GetErrors()
    {
       return this._errors;
    }
}

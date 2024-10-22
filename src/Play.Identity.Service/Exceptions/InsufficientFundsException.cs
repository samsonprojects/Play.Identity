using System;
using System.Runtime.Serialization;

namespace Play.Identity.Service.Exceptions
{
    [Serializable]
    internal class InsufficientFundsException : Exception
    {

        public Guid _userId;
        public decimal _gilToDebit;

        public InsufficientFundsException(Guid userId, decimal gilToDebit) : base($"not enough gil to debit{gilToDebit} by user:{userId}")
        {
            this._userId = userId;
            this._gilToDebit = gilToDebit;
        }


    }
}
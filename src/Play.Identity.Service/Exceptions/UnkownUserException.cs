using System;
using System.Runtime.Serialization;

namespace Play.Identity.Service.Exceptions
{
    [Serializable]
    internal class UnknownUserException : Exception
    {
        private Guid _userId { get; }

        public UnknownUserException(Guid userId) : base($"Unknown user {userId}")
        {
            this._userId = userId;
        }

    }
}
using ABCLearningPortal.DataAccess.Abstraction;
using System;

namespace ABCLearningPortal.DataAccess.DataRequests
{
    public class InsertUser : IDataRequest
    {
        public InsertUser(Guid guid, string firstName, string lastName, string userName)
        {
            Guid = guid;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
        }

        public Guid Guid { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;

        public object? GetParameters()
        {
            throw new NotImplementedException();
        }

        public string GetSql()
        {
            throw new NotImplementedException();
        }
    }
}

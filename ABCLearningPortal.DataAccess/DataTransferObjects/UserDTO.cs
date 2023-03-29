using System;

namespace ABCLearningPortal.DataAccess.DataTransferObjects
{
    public class UserDTO
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
    }
}

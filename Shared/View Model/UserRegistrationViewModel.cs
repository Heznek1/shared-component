using System;

namespace Shared.View_Model
{
    public class UserRegistrationViewModel
    {
        public UserRegistrationViewModel()
        {
            guid = Guid.NewGuid().ToString();
        }

        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirm { get; set; }
        public string guid { get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingAndDelegates
{
    public class EventManager
    {
        public event NotificationService.SendNotification? UserRegistered;
        public event NotificationService.SendNotification? PasswordReset;

        public void OnUserRegistered(string username)
        {
            UserRegistered?.Invoke(username, "Welcome! You have successfully registered.");
        }

        public void OnPasswordReset(string username)
        {
            PasswordReset?.Invoke(username, "Your password has been reset successfully.");
        }
    }

}

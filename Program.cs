using EventHandlingAndDelegates;

NotificationService notificationService = new NotificationService();
EventManager eventManager = new EventManager();

// Subscribe to events with appropriate notification methods
eventManager.UserRegistered += notificationService.SendEmail;
eventManager.UserRegistered += notificationService.SendSMS;

eventManager.PasswordReset += notificationService.SendEmail;
eventManager.PasswordReset += notificationService.SendPushNotification;

// Simulate user registration and password reset events
eventManager.OnUserRegistered("ramya");
eventManager.OnPasswordReset("ramya");
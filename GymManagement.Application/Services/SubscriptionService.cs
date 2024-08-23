namespace GymManagement.Application.Services;

public class SubscriptionService : ISubscriptionService
{
    public Guid CreateSubscription(string subscriptionTpe, Guid adminId)
    {
        return Guid.NewGuid();
    }
}
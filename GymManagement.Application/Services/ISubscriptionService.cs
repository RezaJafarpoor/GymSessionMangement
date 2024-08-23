namespace GymManagement.Application.Services;

public interface ISubscriptionService
{
    Guid CreateSubscription(string subscriptionTpe, Guid adminId);
}
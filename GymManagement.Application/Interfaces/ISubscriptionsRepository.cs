using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Interfaces;

public interface ISubscriptionsRepository
{
    Task AddSubscriptionAsync(Subscription subscription);

}
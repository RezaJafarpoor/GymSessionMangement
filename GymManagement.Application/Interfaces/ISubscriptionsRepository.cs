using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Interfaces;

public interface ISubscriptionsRepository
{
    void AddSubscription(Subscription subscription);

}
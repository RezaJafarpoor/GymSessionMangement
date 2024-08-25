using GymManagement.Application.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Commands;

public class CreateSubscriptionCommandHandler(ISubscriptionsRepository _subscriptionsRepository ) : IRequestHandler<CreateSubscriptionCommand, Subscription>
{
    public async Task<Subscription> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        var sub = new Subscription();
        sub.Id = Guid.NewGuid();
        _subscriptionsRepository.AddSubscription(sub);
        return sub;
    }
}
using MediatR;
using System.Windows.Input;

namespace GymManagement.Application.Subscriptions.Commands;

public record CreateSubscriptionCommand(string SubscriptionType, Guid AdminId) : IRequest<Guid>
{
    
}
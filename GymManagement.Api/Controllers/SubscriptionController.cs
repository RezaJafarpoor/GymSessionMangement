using GymManagement.Application.Subscriptions.Commands;
using GymManagement.Contracts.Subscription;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
    {
        var command = new CreateSubscriptionCommand(request.SubscriptionType.ToString(), request.AdminId);
        var subscriptionId = await sender.Send(command);
        
        var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);
        
        return Ok(response);
    }
    
}
using GymManagement.Application.Services;
using GymManagement.Contracts.Subscription;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController(ISubscriptionService subscriptionService) : ControllerBase
{
    private readonly ISubscriptionService _subscriptionService = subscriptionService;

    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        var subscriptionId = subscriptionService.CreateSubscription(request.SubscriptionType.ToString(), request.AdminId);
        var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);
        
        return Ok(response);
    }
    
}
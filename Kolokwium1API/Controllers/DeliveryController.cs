using Kolokwium1API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium1API.Controllers;

[ApiController]
[Route("api/delivery")]
public class DeliveryController : ControllerBase
{
    private readonly IDeliveryService _service;

    public DeliveryController(IDeliveryService service)
    {
        _service = service;
    }
}
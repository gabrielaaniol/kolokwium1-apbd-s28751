using System.Text.Json;
using Kolokwium1API.Models;

namespace Kolokwium1API.Services;

public class DeliveryService : IDeliveryService
{
    private readonly HttpClient _httpClient;

    public DeliveryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task GetDeliveries()
    {
        var response = await _httpClient.GetAsync("api/deliveries");
        var content = await response.Content.ReadAsStringAsync();
        var deliveries = JsonSerializer.Deserialize<IEnumerable<Delivery>>(content);
        var deliveriesList = deliveries.ToList();
        await using var stream = new MemoryStream();
    }

    public Task<IEnumerable<Delivery>> GetDeliveries(int deliveryId)
    {
        throw new NotImplementedException();
    }

    public Task<Delivery> AddDelivery(int deliveryId, int customerId, string licenceNumber)
    {
        throw new NotImplementedException();
    }
}

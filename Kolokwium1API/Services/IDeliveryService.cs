using Kolokwium1API.Models;

namespace Kolokwium1API.Services;

public interface IDeliveryService
{
    public Task<IEnumerable<Delivery>> GetDeliveries(int deliveryId);
    public Task<Delivery> AddDelivery(int deliveryId, int customerId, string licenceNumber );
    
    
}
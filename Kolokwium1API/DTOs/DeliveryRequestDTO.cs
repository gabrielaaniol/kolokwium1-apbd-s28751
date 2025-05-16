namespace Kolokwium1API.DTOs;

public class DeliveryRequestDTO
{
    public int DeliveryId { get; set; }
    public int CustomerId { get; set; }
    public string LicenceNumber { get; set; }
    
    public string Name { get; set; }
    public int Amount { get; set; }
}
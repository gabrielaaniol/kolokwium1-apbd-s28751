namespace Kolokwium1API.Models;

public class Delivery
{
    int delivery_id { get; set; }
    int customer_id { get; set; }
    int driver_id { get; set; }
    DateTime date { get; set; }
}
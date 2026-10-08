public class PriorityShipment : ShipmentOrder
{
    public string GetServiceNotice()
    {
        return Destination + " 우선 출고";
    }
}

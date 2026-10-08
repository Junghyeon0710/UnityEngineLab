public class ShipmentOrder
{
    public string Destination = "미정";
    public int BoxCount = 1;
    private string trackingPrefix = "SHIP";

    public string GetSummary()
    {
        return trackingPrefix + " · " + Destination + " · " + BoxCount + "상자";
    }

    public void AddBox()
    {
        BoxCount++;
    }
}

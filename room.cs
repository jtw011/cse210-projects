public class room
{
    
    List<string> Devices = new List<string> { "SmartLight", "SmartHeater", "SmartTV" }

    private int deviceTime = 10

    public bool IsOn = true
    public void OffOnLight()
    {

        foreach (SmartDevice SmartDevice in Devices)
        {
            if (SmartDevice is SmartLight)
            {
                SmartDevice.TurnOn();
            }
        }

    }

    public void OffOnDevice()
    {

    }

    public void ItemStatus()
    {
        console.WriteLine("");

    }

    public void ReportStatus()
    {

    }


}
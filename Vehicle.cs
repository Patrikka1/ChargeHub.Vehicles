
public class Vehicle
{
    public string Id { get; }

    public double BatteryKwh { get; }

    public int Percent { get; private set; }

    public Vehicle(string id, double batteryKwh, int percent)
    {
        if (batteryKwh <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(batteryKwh));
        }

        Id = id;
        BatteryKwh = batteryKwh;
        Percent = Math.Clamp(percent, 0, 100);
    }

    public void Charge(double kwh)
    {
        if (kwh <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(kwh));
        }

        Percent = (int)Math.Min(100, Percent + kwh / BatteryKwh * 100);
    }
}

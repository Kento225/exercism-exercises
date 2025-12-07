class RemoteControlCar
{
    public static RemoteControlCar Buy() => new RemoteControlCar();

    private int _distance = 0;
    private int _battery = 100;

    public string DistanceDisplay() => $"Driven {_distance} meters";

    public string BatteryDisplay() => IsBatteryDrained() ? "Battery empty" : $"Battery at {_battery}%";

    public void Drive()
    {
        if (IsBatteryDrained())
        {
            return;
        }
        _distance += 20;
        _battery -= 1;
    }
    public bool IsBatteryDrained() => _battery == 0;
}

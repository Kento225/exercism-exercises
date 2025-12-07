class RemoteControlCar
{

    private int _speed;
    private int _batteryDrain;
    private int _distance;
    private int _battery = 100;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain){
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _battery < _batteryDrain;
    
    public int DistanceDriven() => _distance;

    public void Drive()
    {
        if(BatteryDrained()){
            return;
        }
        _distance += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance){
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car){
        while(!car.BatteryDrained())
        {
            car.Drive();
            if (car.DistanceDriven() >= _distance)
                return true;
        }
        return false;
    }
    
}

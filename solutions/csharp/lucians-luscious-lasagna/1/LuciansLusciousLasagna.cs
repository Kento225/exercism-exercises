class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
    }

    public int RemainingMinutesInOven(int x){
        return ExpectedMinutesInOven() - x;
    }

    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int time){
        return PreparationTimeInMinutes(layers) + time;
    }
}

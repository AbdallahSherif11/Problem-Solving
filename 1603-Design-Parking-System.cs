public class ParkingSystem
{
    int bigGarage;
    int mediumGarage;
    int smallGarage;

    public ParkingSystem(int big, int medium, int small)
    {
        bigGarage = big;
        mediumGarage  = medium;
        smallGarage = small;
    }

    public bool AddCar(int carType)
    {
        if (carType == 1) // Big
        {
            if(bigGarage > 0)
            {
                bigGarage--;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (carType == 2) // Medium
        {
            if (mediumGarage > 0)
            {
                mediumGarage--;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (carType == 3) // small
        {
            if (smallGarage > 0)
            {
                smallGarage--;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */

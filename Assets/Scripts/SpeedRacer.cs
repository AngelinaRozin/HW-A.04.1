using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
  string carModel = "GTR R35";
  string engineType = "V6, Twin Turbo";
  int carWeight = 1609;
  int yearMade = 2009;
  float maxAcceleration = 0.98f;
  bool isCarTypeSedan = false;
  bool hasFrontEngine = true;

    void Start()
    {
        print("The car model is" + carModel + "car's engine type is" + engineType);

        CheckWeight ();
        if (yearMade <= 2009)
        {
            print ( "The car was introduced in" + yearMade);
            int carAge = CalculateAge(yearMade);
            print("So the car is " + carAge + " years old.");
        }
        else
        {
            print ("The car was introduced in the 2010's");
            print ("The car's maximum acceleration is" + maxAcceleration);
        }

        print(CheckCharacteristics());

    }

    void CheckWeight ()
    {
        if (carWeight < 1500)
        {
            print ( carModel + "weighs less than 1500 kg.");
        }
        else
        {
            print ( carModel + "weighs over then 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car type is sedan";
        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, but has a front engine.";
        }
        else 
        {
            return "The car is neither a sedan nor it has a front engine.";
        }


    }


}

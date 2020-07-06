using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    // Not made = 400 because static variables carry on every sinle scene
    public int startMoney = 400;
    void Start ()
    {
        Money = startMoney;
    }
}

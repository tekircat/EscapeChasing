using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    public int startMoney = 10;
    public static int Lives;
    public int startLives = 5;

    public static int Rounds;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }
}

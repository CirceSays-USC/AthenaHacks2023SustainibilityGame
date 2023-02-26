using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int cost;
    public int type;

    public int monIncrease;
    public int powerIncrease;

    public float timeBtwIncreases;
    private float nextIncreaseTime;

    private controlScript cs;

    private void Start()
    {
        cs = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (Time.time > nextIncreaseTime && type == 1)
        {
            nextIncreaseTime = Time.time + timeBtwIncreases;
            cs.totalMoney += monIncrease;
        }
    }
}

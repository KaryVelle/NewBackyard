using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : MonoBehaviour
{
    public SpeedZone speedZone;
    public BirthZone birthZone;
    public HealthZone healthZone;
    public FactoryZone factoryZone;
    public List<bool> zoneList;
    public List<bool> zoneListEnem;
    public bool pSpeedZone = true;
    public bool eSpeedZone = true;
    public bool pBirthZone = true;
    public bool eBirthZone = true;
    public bool pFactoryZone = true;
    public bool eFactoryZone = true;
    public bool pHealthZone = true;
    public bool eHealthZone = true;

    private void Start()
    {
        StartCoroutine(DelayToconquer());
    }
    private void Update()
    {
        if (speedZone.allyZoneConquered && pSpeedZone && speedZone.canConquerd)
        {
            zoneList.Add(speedZone);
            pSpeedZone = false;
            eSpeedZone = true;
        }
        if (!speedZone.allyZoneConquered && eSpeedZone && speedZone.canConquerd)
        {
            zoneListEnem.Add(speedZone);
            eSpeedZone = false;
            pSpeedZone = true;
        }
        
        if (birthZone.allyZoneConquered && pBirthZone && birthZone.canConquerd)
        {
            zoneList.Add(birthZone);
            pBirthZone = false;
            eBirthZone = true;
        }
        if (!birthZone.allyZoneConquered && eBirthZone && birthZone.canConquerd)
        {
            zoneListEnem.Add(birthZone);
            eBirthZone = false;
            pBirthZone = true;
        }
       
        if (factoryZone.allyZoneConquered && pFactoryZone && factoryZone.canConquerd)
        {
            zoneList.Add(factoryZone);
            pFactoryZone = false;
            eFactoryZone = true;
        }
        if (!factoryZone.allyZoneConquered && eFactoryZone && factoryZone.canConquerd)
        {
            zoneListEnem.Add(factoryZone);
            eFactoryZone = false;
            pFactoryZone = true;
        }
        
        if (healthZone.allyZoneConquered && pHealthZone && healthZone.canConquerd)
        {
            zoneList.Add(healthZone);
            pHealthZone = false;
            eHealthZone = true;
        }
        if (!healthZone.allyZoneConquered && eHealthZone && healthZone.canConquerd)
        {
            zoneListEnem.Add(healthZone);
            eHealthZone = false;
            pHealthZone = true;
        }
    }

    IEnumerator DelayToconquer()
    {
        yield return new WaitForSeconds(30f);
        speedZone.canConquerd = true;
        healthZone.canConquerd = true;
        factoryZone.canConquerd = true;
        birthZone.canConquerd = true;
    }
}

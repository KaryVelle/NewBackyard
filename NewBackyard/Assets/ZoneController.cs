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

    private void Update()
    {
        if (speedZone.allyZoneConquered)
        {
            zoneList.Add(speedZone);
        }
        if (!speedZone.allyZoneConquered)
        {
            zoneListEnem.Add(speedZone);
        }
        
        
        if (birthZone.allyZoneConquered)
        {
            zoneList.Add(birthZone);
        }
        if (!birthZone.allyZoneConquered)
        {
            zoneListEnem.Add(birthZone);
        }
        
       
        if (factoryZone.allyZoneConquered)
        {
            zoneList.Add(factoryZone);
        }
        if (!factoryZone.allyZoneConquered)
        {
            zoneListEnem.Add(factoryZone);
        }
        
        if (healthZone.allyZoneConquered)
        {
            zoneList.Add(healthZone);
        }
        if (!healthZone.allyZoneConquered)
        {
            zoneListEnem.Add(healthZone);
        }
    }
}

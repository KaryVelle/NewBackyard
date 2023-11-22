using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : Steering
{
    public bool arrival = false;
    public float slowingRadius;

    public override Vector3 GetForce()
    {
        float distance = Vector3.Distance(Target, Position);
        DesiredVelocity = (Target - Position).normalized * speed;

        if (arrival)
        {
            if (distance <= slowingRadius)
            {
                DesiredVelocity = DesiredVelocity.normalized * speed * (distance / slowingRadius);
            }
            else
            {
                DesiredVelocity = DesiredVelocity.normalized * speed;
            }
        }

        Vector3 steering = DesiredVelocity - Velocity;
        return steering;
    }
}

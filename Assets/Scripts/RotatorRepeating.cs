using UnityEngine;

public class RotatorRepeating : Rotator
{
    protected override void Rotate()
    {
        transform.rotation = Quaternion.Euler(0f, Interpolation.Sine(_speed) * 360, 0f);
    }
}
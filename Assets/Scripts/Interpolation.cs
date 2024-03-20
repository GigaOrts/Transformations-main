using UnityEngine;

public static class Interpolation
{
    private const float tau = Mathf.PI * 2;

    public static float Sine(float duration)
    {
        float cycle = Time.time * duration;

        float rawSinWave = Mathf.Sin(tau * cycle);

        float factor = (rawSinWave * 0.5f) + 0.5f;

        return factor;
    }
}
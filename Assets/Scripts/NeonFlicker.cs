using UnityEngine;

public class NeonFlicker : MonoBehaviour
{
    public float minIntensity = 0.8f;
    public float maxIntensity = 1.2f;
    public float flickerSpeed = 0.1f;

    private Light neonLight;
    private float baseIntensity;

    void Start()
    {
        neonLight = GetComponent<Light>();
        if (neonLight != null) baseIntensity = neonLight.intensity;
    }

    void Update()
    {
        if (neonLight != null)
        {
            float flicker = Mathf.Sin(Time.time * flickerSpeed) * 0.1f + 1f;
            neonLight.intensity = baseIntensity * Mathf.Lerp(minIntensity, maxIntensity, flicker);
        }
    }
}
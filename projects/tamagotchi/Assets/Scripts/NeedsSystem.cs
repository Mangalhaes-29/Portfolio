using UnityEngine;

public class NeedsSystem : MonoBehaviour
{
    public float hunger = 100f;
    public float sleep = 100f;

    public float teeth = 100f;
    public float bath = 100f;

    void Update()
    {
        hunger -= Time.deltaTime * 2f;
        sleep -= Time.deltaTime * 1.5f;
        teeth -= Time.deltaTime * 1f;
        bath -= Time.deltaTime * 0.8f;

        
        hunger = Mathf.Clamp(hunger, 0, 100);
        sleep = Mathf.Clamp(sleep, 0, 100);
        teeth = Mathf.Clamp(teeth, 0, 100);
        bath = Mathf.Clamp(bath, 0, 100);

    }


    public float GetEnergy()
    {
        return (hunger + sleep) / 2f;
    }

    public float GetHygiene()
    {
        return (teeth + bath) / 2f;
    }
}
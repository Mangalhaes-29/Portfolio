using UnityEngine;
using UnityEngine.UI;

public class NeedsUI : MonoBehaviour
{
    public NeedsSystem needs;

    public Slider energyBar;
    public Slider hygieneBar;

    float currentEnergy;
    float currentHygiene;

    public float smoothSpeed = 5f;

    void Start()
    {
        currentEnergy = needs.GetEnergy() / 100f;
        currentHygiene = needs.GetHygiene() / 100f;
    }

    void Update()
    {
        float targetEnergy = needs.GetEnergy() / 100f;
        float targetHygiene = needs.GetHygiene() / 100f;

        currentEnergy = Mathf.Lerp(currentEnergy, targetEnergy, Time.deltaTime * smoothSpeed);
        currentHygiene = Mathf.Lerp(currentHygiene, targetHygiene, Time.deltaTime * smoothSpeed);

        energyBar.value = currentEnergy;
        hygieneBar.value = currentHygiene;
    }
}
using UnityEngine;

public class BoostersCount : MonoBehaviour
{
    private TrollCounter _trollCounter;
    private void Start()
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
    }

    public void ClickToBooster()
    {
        _trollCounter.trollPerClick += 1;
    }
}

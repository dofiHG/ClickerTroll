using UnityEngine;
using UnityEngine.UI;

public class FaceChanger : MonoBehaviour
{
    private TrollCounter trollCounter;
    private Image trollFace;

    private void Start()
    {
        trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        trollFace = gameObject.GetComponent<Image>();
    }

    private void Update()
    {
        switch(trollCounter.level)
        {
            case 1: break;
            case 2: break;
            case 3: break;
            case 4: break;
            case 5: break;
            case 6: break;
            case 7: break;
        }
    }
}

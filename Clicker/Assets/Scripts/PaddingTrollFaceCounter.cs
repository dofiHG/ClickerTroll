using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PaddingTrollFaceCounter : MonoBehaviour
{
    private TMP_Text _counterText;
    public Transform _currentTransform;

    private void Start()
    {
        _counterText = GameObject.FindGameObjectWithTag("CounterTroll").GetComponent<TMP_Text>();
        _currentTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        switch(_counterText.text.Length)
        {
            case 1:
                _currentTransform.position = new Vector3(358, 558, 0); break;
            case 2:
                _currentTransform.position = new Vector3(375, 558, 0); break;
            case 3:
                _currentTransform.position = new Vector3(392, 558, 0); break;
            case 4:
                _currentTransform.position = new Vector3(409, 558, 0); break;
            case 5:
                _currentTransform.position = new Vector3(409, 558, 0); break;
            case 6:
                _currentTransform.position = new Vector3(426, 558, 0); break;
            case 7:
                _currentTransform.position = new Vector3(443, 558, 0); break;
            case 8:
                _currentTransform.position = new Vector3(460, 558, 0); break;
        }
    }
}

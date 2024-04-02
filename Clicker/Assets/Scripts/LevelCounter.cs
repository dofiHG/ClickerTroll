using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    private long _levelAmount;
    private TrollCounter _trollCounter;
    private Slider _slider;

    public Button _button;
    public TMP_Text _levelText;

    private void Start() 
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _slider.value = _trollCounter.countTrollNow;
        _levelText.text = $"Level {_trollCounter.level}";
        
        if (_trollCounter.countTrollNow > _levelAmount)
        {
            _trollCounter.level++;

        }

        switch (_trollCounter.level)
        {
            case 1: _levelAmount = 100; break;
            case 2: _levelAmount = 1000; break;
            case 3: _levelAmount = 5000; break;
            case 4: _levelAmount = 50000; break;
            case 5: _levelAmount = 500000; break;
            case 6: _levelAmount = 5000000; break;
            case 7: _levelAmount = 500000000; break;
            case 8: _levelAmount = 5000000000; break;
            case 9: _levelAmount = 50000000000; break;
            case 10: _levelAmount = 500000000000; break;
        }

        _slider.maxValue = _levelAmount;
    }
}

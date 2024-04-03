using System;
using TMPro;
using UnityEngine;

public class ViewTextUpTheFace : MonoBehaviour
{
    [SerializeField] private TMP_Text _textUpTheFace;
    public TrollCounter _trollCounter;
    public GameObject _prefab;
    public Transform _canvas;
    private GameObject _instantiate;
    public TMP_Text _count;

    public static string[] formats_names = new[] { "", "K", "M", "B", "T", "Q", "Qn", "S" };
    private void Start() => InvokeRepeating("Timmer", 0, 1);

    private string ConvertToNormaiView(double money)
    {
        if(money < 1000)
            return money.ToString("#");

        else
        {
            int i = 0;
            while (i + 1 < formats_names.Length && money >= 1000f) 
            {
                i++;
                money /= 1000f;
            }
            return money.ToString("#.##") + formats_names[i];
        }
    }

    public void Click()
    {
        _textUpTheFace.text = $"+ {_trollCounter.trollPerClick}";
        _trollCounter.countTrollNow += _trollCounter.trollPerClick;
        _count.text = ConvertToNormaiView(_trollCounter.countTrollNow);
        _prefab.GetComponent<TMP_Text>().text = "+" + ConvertToNormaiView(_trollCounter.trollPerClick);
        _instantiate = Instantiate(_prefab, _canvas.transform);
        Destroy(_instantiate, 1);
    }

    private void Timmer()
    {
        _trollCounter.countTrollNow += _trollCounter.trollPerSecond;
        _count.text = ConvertToNormaiView(_trollCounter.countTrollNow);
    }
}








/*
        if (_trollCounter.countTrollNow >= 1000 && _trollCounter.countTrollNow < 1000000)
            _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000) / 100}Ê";
        else if (_trollCounter.countTrollNow >= 1000000 && _trollCounter.countTrollNow < 1000000000)
        { 
            _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000) / 100}M";
            _prefab.GetComponent<TMP_Text>().text = $"{Math.Truncate(100 * _trollCounter.trollPerClick / 1000) / 100}M";
        }
        else if (_trollCounter.countTrollNow >= 1000000000 && _trollCounter.countTrollNow < 1000000000000)
        { 
            _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000) / 100}B";
            _prefab.GetComponent<TMP_Text>().text = $"{Math.Truncate(100 * _trollCounter.trollPerClick / 1000) / 100}B";
        }
        else if (_trollCounter.countTrollNow >= 1000000000000 && _trollCounter.countTrollNow < 1000000000000000)
        { 
            _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000000) / 100}T";
            _prefab.GetComponent<TMP_Text>().text = $"{Math.Truncate(100 * _trollCounter.trollPerClick / 1000) / 100}T";
        }
        else if (_trollCounter.countTrollNow >= 0 && _trollCounter.countTrollNow < 1000)
        { 
            _count.text = _trollCounter.countTrollNow.ToString();
            _prefab.GetComponent<TMP_Text>().text = _trollCounter.trollPerClick.ToString();
        }

        if(_trollCounter.trollPerClick >= 1000 && _trollCounter.trollPerClick < 1000000)
            _prefab.GetComponent<TMP_Text>().text = $"{Math.Truncate(100 * _trollCounter.trollPerClick / 1000) / 100}Ê";*/








/*if (_trollCounter.countTrollNow >= 1000 && _trollCounter.countTrollNow < 1000000)
            { _count.text = $"{Math.Truncate(100*_trollCounter.countTrollNow / 1000)/100}Ê"; }
        else if (_trollCounter.countTrollNow >= 1000000 && _trollCounter.countTrollNow < 1000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000) / 100}M"; }
        else if (_trollCounter.countTrollNow >= 1000000000 && _trollCounter.countTrollNow < 1000000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000) / 100}B"; }
        else if (_trollCounter.countTrollNow >= 1000000000000 && _trollCounter.countTrollNow < 1000000000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000000) / 100}T"; }
        else if (_trollCounter.countTrollNow >= 0 && _trollCounter.countTrollNow < 1000)
            { _count.text = _trollCounter.countTrollNow.ToString(); }*/
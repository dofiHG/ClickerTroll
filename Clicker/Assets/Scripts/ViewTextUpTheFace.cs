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

    private void Start() => InvokeRepeating("Timmer", 0, 1);

    public void Click()
    {
        _textUpTheFace.text = $"+ {_trollCounter.trollPerClick}";
        _trollCounter.countTrollNow += _trollCounter.trollPerClick;
        if (_trollCounter.countTrollNow >= 1000 && _trollCounter.countTrollNow < 1000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000) / 100}Ê"; }
        else if (_trollCounter.countTrollNow >= 1000000 && _trollCounter.countTrollNow < 1000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000) / 100}M"; }
        else if (_trollCounter.countTrollNow >= 1000000000 && _trollCounter.countTrollNow < 1000000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000) / 100}B"; }
        else if (_trollCounter.countTrollNow >= 1000000000000 && _trollCounter.countTrollNow < 1000000000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000000) / 100}T"; }
        else if (_trollCounter.countTrollNow >= 0 && _trollCounter.countTrollNow < 1000)
            { _count.text = _trollCounter.countTrollNow.ToString(); }
        _instantiate = Instantiate(_prefab, _canvas.transform);
        Destroy(_instantiate, 1);
    }

    private void Timmer()
    {
        _trollCounter.countTrollNow += _trollCounter.trollPerSecond;
        if (_trollCounter.countTrollNow >= 1000 && _trollCounter.countTrollNow < 1000000)
            { _count.text = $"{Math.Truncate(100*_trollCounter.countTrollNow / 1000)/100}Ê"; }
        else if (_trollCounter.countTrollNow >= 1000000 && _trollCounter.countTrollNow < 1000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000) / 100}M"; }
        else if (_trollCounter.countTrollNow >= 1000000000 && _trollCounter.countTrollNow < 1000000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000) / 100}B"; }
        else if (_trollCounter.countTrollNow >= 1000000000000 && _trollCounter.countTrollNow < 1000000000000000)
            { _count.text = $"{Math.Truncate(100 * _trollCounter.countTrollNow / 1000000000000) / 100}T"; }
        else if (_trollCounter.countTrollNow >= 0 && _trollCounter.countTrollNow < 1000)
            { _count.text = _trollCounter.countTrollNow.ToString(); }
    }
}

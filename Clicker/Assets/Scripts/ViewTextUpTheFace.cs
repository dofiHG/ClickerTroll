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

    public void Click()
    {
        _textUpTheFace.text = ($"+ {_trollCounter.trollPerClick.ToString()}");
        _trollCounter.countTrollNow += _trollCounter.trollPerClick;
        _count.text = _trollCounter.countTrollNow.ToString();
        _instantiate = Instantiate(_prefab, _canvas.transform);
        Destroy(_instantiate, 1);
    }

}

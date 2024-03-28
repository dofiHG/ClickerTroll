using TMPro;
using UnityEngine;

public class ViewTextUpTheFace : MonoBehaviour
{
    [SerializeField] private TMP_Text _textUpTheFace;
    public TrollCounter _trollCounter;

    public void Click()
    {
        _trollCounter.countTrollNow += _trollCounter.trollPerClick;
        _textUpTheFace.text = _trollCounter.trollPerClick.ToString();
    }

}

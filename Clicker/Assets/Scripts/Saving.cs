using UnityEngine;
using YG;

public class Saving : MonoBehaviour
{
    public TrollCounter _trollCounter;

    private void Start()
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        _trollCounter.trollPerClick = YandexGame.savesData.trollPerClick;
        _trollCounter.countTrollNow = YandexGame.savesData.countTrollNow;
        Save();
    }

    public void Save()
    {
        YandexGame.savesData.trollPerClick = _trollCounter.trollPerClick;
        YandexGame.savesData.countTrollNow = _trollCounter.countTrollNow;
        YandexGame.savesData.trollPerSecond = _trollCounter.trollPerSecond;
        YandexGame.savesData.level = _trollCounter.level;

        YandexGame.SaveProgress();
        Invoke("Save", 5);
    }

    public void Load() => YandexGame.LoadProgress();
}

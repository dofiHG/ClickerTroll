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
        _trollCounter.trollPerSecond = YandexGame.savesData.trollPerSecond;
        _trollCounter.level = YandexGame.savesData.level;
        Save();
    }

    public void Save()
    {
        YandexGame.savesData.trollPerClick = _trollCounter.trollPerClick;
        YandexGame.savesData.countTrollNow = _trollCounter.countTrollNow;
        YandexGame.savesData.trollPerSecond = _trollCounter.trollPerSecond;
        YandexGame.savesData.level = _trollCounter.level - 1;

        YandexGame.SaveProgress();
        Invoke("Save", 5);
    }

    public void Load() => YandexGame.LoadProgress();
}

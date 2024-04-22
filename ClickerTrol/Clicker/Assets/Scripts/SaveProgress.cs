using UnityEngine;
using YG;

public class SaveProgress : MonoBehaviour
{
    private TrollCounter _trollCounter;

    private void Start()
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();    
    }

    /*private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }*/

    /*public void Save()
    {
        YandexGame.savesData.money = int.Parse(integerText.text);
        YandexGame.savesData.newPlayerName = stringifyText.text.ToString();

        for (int i = 0; i < booleanArrayToggle.Length; i++)
            YandexGame.savesData.openLevels[i] = booleanArrayToggle[i].isOn;

        YandexGame.SaveProgress();
    }

    public void Load() => YandexGame.LoadProgress();

    public void GetLoad()
    {
        integerText.text = string.Empty;
        stringifyText.text = string.Empty;

        integerText.placeholder.GetComponent<Text>().text = YandexGame.savesData.money.ToString();
        stringifyText.placeholder.GetComponent<Text>().text = YandexGame.savesData.newPlayerName;

        for (int i = 0; i < booleanArrayToggle.Length; i++)
            booleanArrayToggle[i].isOn = YandexGame.savesData.openLevels[i];
    }*/
}

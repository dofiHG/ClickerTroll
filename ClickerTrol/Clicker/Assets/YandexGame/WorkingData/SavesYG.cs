
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public int langiageInt = 0;
        public int level = 0;
        public float trollPerClick = 1;
        public float trollPerSecond = 0;
        public float countTrollNow = 0;

        public SavesYG() {}
    }
}

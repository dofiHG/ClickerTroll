using UnityEngine;
using UnityEngine.UI;

public class SoundMute : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    private Image image;

    private void Start() => image = GetComponent<Image>();

    public void SoundSound()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        if (image.sprite == sprites[1]) { image.sprite = sprites[0]; }
        else { image.sprite = sprites[1]; }
    }
}
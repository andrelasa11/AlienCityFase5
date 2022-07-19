using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Text scoreText;

    public void SetHealthBar(float value)
    {
        healthBar.value = value;
    }

    public void SetScore(float value)
    {
        scoreText.text = value.ToString("N0");
    }

    public void SetMaxHealthBar(float value)
    {
        healthBar.maxValue = value;
    }
}

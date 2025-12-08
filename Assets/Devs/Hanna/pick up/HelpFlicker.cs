using UnityEngine;
using UnityEngine.UI;

public class ButtonFadeFlicker : MonoBehaviour
{
    public Button TargetButton;
    public float Speed = 3f;
    private Image _BtnImage;

    private void Start()
    {
        _BtnImage = TargetButton.GetComponent<Image>();
    }
    public void Update()
    {
        Fade();
    }
    /// <summary>
    /// makes it fade in and out
    /// </summary>
    private void Fade()
    {
        float alpha = (Mathf.Sin(Time.time * Speed) + 1f) / 2f; // 0-1 range
        Color c = _BtnImage.color;
        c.a = alpha;
        _BtnImage.color = c;
    }
}



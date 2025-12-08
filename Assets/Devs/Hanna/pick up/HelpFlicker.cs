using UnityEngine;
using UnityEngine.UI;

public class ButtonFadeFlicker : MonoBehaviour
{
    public Button targetButton;
    public float speed = 3f;

    private Image btnImage;

    void Start()
    {
        btnImage = targetButton.GetComponent<Image>();
    }

    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * speed) + 1f) / 2f; // 0-1 range
        Color c = btnImage.color;
        c.a = alpha;
        btnImage.color = c;
    }
}



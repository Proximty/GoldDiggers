using UnityEngine;

public class help : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Button;
    public void OpenHelp()
    {
        Canvas.SetActive(true);
        Button.SetActive(false);
    }
    public void CloseHelp()
    {
        Canvas.SetActive(false);
        Button.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Canvas;
    public void Restart()
    {
        SceneManager.LoadScene("");
    }

    public void Continue()
    {
        Canvas.SetActive(false);
    }   
}

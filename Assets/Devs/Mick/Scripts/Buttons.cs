using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject _canvas;
    public void Restart()
    {
        SceneManager.LoadScene("");
    }

    public void Continue()
    {
        _canvas.SetActive(false);
    }   
}

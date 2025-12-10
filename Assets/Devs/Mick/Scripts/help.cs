using UnityEngine;
using UnityEngine.SceneManagement;

public class help : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Button;
    public void OpenHelp()
    {
         SceneManager.LoadScene("Mick scene");
    }
    public void CloseHelp()
    {
        SceneManager.LoadScene("fossils");
    }
}

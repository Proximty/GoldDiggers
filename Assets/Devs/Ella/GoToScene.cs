using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    [SerializeField] private string _scenename;
    [SerializeField] private SlideUpText _slideUpText;

    public void LoadScene()
    {
        SceneManager.LoadScene(_scenename);
        if (_slideUpText != null) { 
            _slideUpText._AudioSource.Stop();
        }
    }
}

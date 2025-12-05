using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    [SerializeField] private string _scenename;
    
    public void LoadScene()
    {
        SceneManager.LoadScene(_scenename);
    }
}

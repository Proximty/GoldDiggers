using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public interface IGoToRockScene
{
    void GoToRockSceneHEHE();
}



public class GoToRockScene : MonoBehaviour, IGoToRockScene
{
    
    [SerializeField] private string SceneName;
    public void GoToRockSceneHEHE() {
        SceneManager.LoadScene(SceneName);
    }
}

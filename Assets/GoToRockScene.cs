using UnityEngine;
using UnityEngine.SceneManagement;
public interface IGoToRockScene
{
    void GoToRockSceneHEHE();
}


public class GoToRockScene : MonoBehaviour, IGoToRockScene
{
   public void GoToRockSceneHEHE() {
        SceneManager.LoadScene("Ella");
    }
}

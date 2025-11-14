using UnityEditor.SceneManagement;
using UnityEngine;

public interface IBrushable
{
    public void Brush();
}
public class dirt : MonoBehaviour,IBrushable
{
    [SerializeField] private GameObject _gem;
    [SerializeField] private GameObject _stoneInfo;
    [SerializeField] private int _stageDirt = 1;
    public void Brush()
    {

        switch (_stageDirt)
        {
            case 1:
                SetTransfromOfRock(0.3f);
                _stageDirt++;
                break;
            case 2:
                SetTransfromOfRock(0.1f);
                _stageDirt++;
                break;
            case 3:
                Debug.Log("U removed the dirt from the rock");
                _gem.SetActive(true);
                _stoneInfo.SetActive(true);
                Destroy(this.gameObject);
                break;
        }
        
    }
    private void SetTransfromOfRock(float size)
    {
        this.gameObject.transform.localScale = new Vector3(size, size, size);
        //this.gameObject.transform.eulerAngles = new Vector3 (0, rotation, 0);

    }


}

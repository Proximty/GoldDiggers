using Unity.VisualScripting;
using UnityEngine;

public interface IBreakable
{
    void Break();
}
public class rock1 : MonoBehaviour, IBreakable
{
    [SerializeField] private GameObject _dirt;
    [SerializeField] private int _stageRock = 1;
    public void Break()
    {
        switch (_stageRock)
        {
            case 1:
                SetTransfromOfRock(0.8480377f);
                _stageRock++;
                break;
            case 2:
                SetTransfromOfRock(0.5927531f);
                _stageRock++;
                break;
            case 3:
                Debug.Log("The rock breaks");
                _dirt.SetActive(true);
                Destroy(this.gameObject);
                break;
        }
                
    }

    //fucntion to change the size of the rock and the y rotation
    private void SetTransfromOfRock(float size)
    {
        this.gameObject.transform.localScale = new Vector3(size, size, size);
        //this.gameObject.transform.eulerAngles = new Vector3 (0, rotation, 0);

    }
}

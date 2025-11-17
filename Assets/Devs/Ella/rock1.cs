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
    public bool InRockArea = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "axe")
        {
            //Debug.Log("u enetered the rock area");
            InRockArea=true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "axe")
        {
            //Debug.Log("u exited the rock area");
            InRockArea=false;
        }
    }
    public void Break()
    {
        switch (_stageRock)
        {
            case 1:
                SetTransfromOfRock(1.6960754f);
                _stageRock++;
                break;
            case 2:
                SetTransfromOfRock(1.1855062f);
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

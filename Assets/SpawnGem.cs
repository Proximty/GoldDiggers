using UnityEngine;

public class SpawnGem : MonoBehaviour
{
    //string for info maken
    //find the tmp and set the text to the string
    public string FossilInfo;
    //public Animator Animator;

    private void Start()
    {
        
        if (this.gameObject.tag == "ammoniet")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(-90f, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z);
        }if(this.gameObject.tag == "quarz")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(90f, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z);
        }
       
    }
}

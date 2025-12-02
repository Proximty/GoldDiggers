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
        if(this.gameObject.tag == "mosasaurus")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(-90f, 90, this.gameObject.transform.eulerAngles.z);
            this.gameObject.transform.position = new Vector3(0.67f, -0.13f, -0.1600001f);

        }
        if(this.gameObject.tag == "plesiosaurus")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, 90, this.gameObject.transform.eulerAngles.z);
            this.gameObject.transform.position = new Vector3(-0.49f, 0f, -0.48f);
        }
        if(this.gameObject.tag == "calsite")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(90f, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z);
            this.gameObject.transform.position = new Vector3(0.73f, -0.568f, -0.64f);
        }
        if(this.gameObject.tag == "sphalerite")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, -90, this.gameObject.transform.eulerAngles.z);
            this.gameObject.transform.position = new Vector3(0.68f, 0.48f, -1.18f);
        }
        if(this.gameObject.tag == "tand")
        {
            Debug.Log("rotate it!");
            this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, 90, this.gameObject.transform.eulerAngles.z);
            this.gameObject.transform.position = new Vector3(0.28f, 0.43f, 0f);
        }
    }
       
}


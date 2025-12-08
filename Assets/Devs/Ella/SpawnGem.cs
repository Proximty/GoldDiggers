using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnGem : MonoBehaviour
{
    //string for info maken
    //find the tmp and set the text to the string
    public string FossilInfo;
    //public Animator Animator;
    [SerializeField] private pickup _pickUpScipt;
    [SerializeField] private GameObject dirt;
    [SerializeField] private BoxCollider coll;
    [SerializeField] private string _sceneName;

    private void Start()
    {
        _sceneName = SceneManager.GetActiveScene().name;
        if (this.gameObject.tag == "ammoniet")
        {
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.position = new Vector3(0.91f, 0.47f, -0.03780033f);
            }
            this.gameObject.transform.eulerAngles = new Vector3(-90f, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z);
        }if(this.gameObject.tag == "quarz")
        {
            
            this.gameObject.transform.eulerAngles = new Vector3(90f, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z);
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.position = new Vector3(0.67f, 0.45f, -0.16f);
            }

        }
        if(this.gameObject.tag == "mosasaurus")
        {
            
            
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.position = new Vector3(0.67f, -0.13f, -0.1600001f);
                this.gameObject.transform.eulerAngles = new Vector3(-90f, 90, this.gameObject.transform.eulerAngles.z);
            }
            else
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -0.72f);
                this.gameObject.transform.eulerAngles = new Vector3(-90f, 90f, 0f);
            }

        }
        if(this.gameObject.tag == "plesiosaurus")
        {
            
            
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, 90, this.gameObject.transform.eulerAngles.z);
                this.gameObject.transform.position = new Vector3(-0.49f, 0f, -0.48f);
            }
            else
            {
                this.gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
            }
        }
        if(this.gameObject.tag == "calsite")
        {
            
            this.gameObject.transform.eulerAngles = new Vector3(90f, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z);
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.position = new Vector3(0.73f, -0.568f, -0.64f);
            }
        }
        if(this.gameObject.tag == "sphalerite")
        {
            
            
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, -90, this.gameObject.transform.eulerAngles.z);
                this.gameObject.transform.position = new Vector3(0.68f, 0.1f, -1.18f);
            }
            else
            {
                this.gameObject.transform.eulerAngles = new Vector3(0, -90, 0);
            }
        }
        if(this.gameObject.tag == "tand")
        {
            
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, 90, this.gameObject.transform.eulerAngles.z);
                this.gameObject.transform.position = new Vector3(0.89f, 0.43f, 0f);
            }
            else
            {
                this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x, 90, 0);
            }
        }
        if(this.gameObject.tag == "prite")
        {
            if (_sceneName != "level 1")
            {
                this.gameObject.transform.position = new Vector3(0.55f, 0.15f, -0.16f);
            }
            else
            {
               this.gameObject.transform.eulerAngles = new Vector3(-14.425f, 0, 0);
            }
        }
        dirt = GameObject.Find("dirt");
    }
    private void Update()
    {
        if (_sceneName != "level 1")
        {
            if (dirt == null)
            {
                _pickUpScipt.enabled = true;
                coll.enabled = true;
            }
        }
    }

}


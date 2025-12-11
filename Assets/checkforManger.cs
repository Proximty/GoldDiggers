using UnityEngine;

public class checkforManger : MonoBehaviour
{

    [SerializeField] private FossilManager m_Manager;

    private void Start()
    {
        m_Manager =  GameObject.Find("FossilManager").GetComponent<FossilManager>();
        
    }
    private void Update()
    {
        if (m_Manager != null)
        {
            Debug.LogError("FossilManger was actually found");
        }
        else if (m_Manager == null)
        {
            Debug.LogError("FossilManger was not found :/");
        } 
    }
}

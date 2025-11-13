using UnityEngine;

public class resetcanvas : MonoBehaviour
{
    public int NothingTimer;

    void Start()
    {
        NothingTimer = 0;
    }


    void Update()
    {
        
    }

    void SpawnCanvas()
    {
        if (NothingTimer > 30)
        {
            Instantiate(gameObject, new Vector3(0, 0, 0), Quaternion.identity);
        }   
    }
}

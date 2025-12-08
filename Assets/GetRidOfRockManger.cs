using UnityEngine;

public class GetRidOfRockManger : MonoBehaviour
{
    [SerializeField] GameObject RockManager;

    private void Start()
    {
        RockManager = GameObject.Find("FossilManager");
    }
    public void DelelteRockMangerScript()
    {
        if (RockManager != null)
        {

            Destroy(RockManager);
        }
    }
}

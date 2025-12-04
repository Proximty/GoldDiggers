using UnityEngine;

public class GetRidOfRockManger : MonoBehaviour
{
    [SerializeField] GameObject RockManager;

    private void Start()
    {
        RockManager = GameObject.Find("RockManger");
    }
    public void DelelteRockMangerScript()
    {
        if (RockManager != null)
        {

            Destroy(RockManager);
        }
    }
}

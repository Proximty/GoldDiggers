using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    [SerializeField] private float _destoyAfterTime;
    void Update()
    {
        Destroy(this.gameObject, _destoyAfterTime);
    }
}

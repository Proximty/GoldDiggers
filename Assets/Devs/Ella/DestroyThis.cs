using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    /// <summary>
    /// Dit script is zodat je na het activeren van een object het weer kan verwijderen na bepaalde tijd
    /// </summary>
    [SerializeField] private float _destoyAfterTime;
    void Update()
    {
        Destroy(this.gameObject, _destoyAfterTime);
    }
}

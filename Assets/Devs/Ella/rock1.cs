using Unity.VisualScripting;
using UnityEngine;

public interface IBreakable
{
    void Break();
}
public class rock1 : MonoBehaviour, IBreakable
{
    [SerializeField] private GameObject dirt;
    [SerializeField] private GameObject gem;
    public void Break()
    {
        Debug.Log("The rock breaks");
        dirt.SetActive(true);
        gem.SetActive(true);
        Destroy(this.gameObject);
    }
}

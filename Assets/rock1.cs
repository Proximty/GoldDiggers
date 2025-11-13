using Unity.VisualScripting;
using UnityEngine;

public interface IBreakable
{
    void Break();
}
public class rock1 : MonoBehaviour, IBreakable
{
    public void Break()
    {
        Debug.Log("The rock breaks");
        Destroy(this.gameObject, 1f);
    }
}

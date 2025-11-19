using UnityEngine;

public class axe : MonoBehaviour
{
    /// <summary>
    /// breaks the stone 
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {

        IBreakable _breakable = collision.GetComponent<IBreakable>();
        if (_breakable != null)
        {
            _breakable.Break();
        }
    }
}

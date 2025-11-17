using UnityEngine;

public class axe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        IBreakable _breakable = collision.GetComponent<IBreakable>();
        if (_breakable != null)
        {
            _breakable.Break();
        }
    }
}

using UnityEngine;

public class brush : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        IBrushable _brushable = collision.GetComponent<IBrushable>();
        if (_brushable != null)
        {
            _brushable.Brush();
        }
    }
}
   

   


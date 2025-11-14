using UnityEngine;

public interface IBrushable
{
    public void Brush();
}
public class dirt : MonoBehaviour,IBrushable
{
    [SerializeField] private GameObject RockInfoText;
    public void Brush()
    {
        Debug.Log("U removed the dirt from the rock");
        RockInfoText.SetActive(true);
        Destroy(this.gameObject);
    }
}

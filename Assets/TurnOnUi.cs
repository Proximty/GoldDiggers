using UnityEngine;

public class TurnOnUi : MonoBehaviour
{
    [SerializeField] private GameObject _uiToTurnOn;
    public void TurnUiOn()
    {
        _uiToTurnOn.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

using UnityEngine;

public class TurnOnUi : MonoBehaviour
{
    [SerializeField] private GameObject _uiToTurnOn;
    [SerializeField] private GameObject _uiToTurnOff;
    public void TurnUiOn()
    {
        _uiToTurnOn.SetActive(true);
        _uiToTurnOff.SetActive(false);
    }
}

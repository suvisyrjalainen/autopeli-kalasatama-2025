using TMPro;
using UnityEngine;

public class Maaliviiva : MonoBehaviour
{
    private bool winnerDeclared = false;

    [SerializeField] private TextMeshProUGUI winnerText;

    private void OnTriggerEnter(Collider auto)
    {
        var id = auto.GetComponent<CarIdentity>();
        var tarkistaja = auto.GetComponent<CheckpointTarkistus>();
        if (tarkistaja.CanWin())
        {
            if (tarkistaja.laps == GameManager.Instance.lapsToWin && !winnerDeclared)
            {
                winnerDeclared = true;
                winnerText.text = "Race Finished!\nWinner: " + id.car_name;
                winnerText.color = Color.green;
                winnerText.gameObject.SetActive(true);
            }
            else
            {
                tarkistaja.ResetLap();
            }
        }
    }
}
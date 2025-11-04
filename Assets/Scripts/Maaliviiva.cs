using UnityEngine;

public class Maaliviiva : MonoBehaviour
{
    private void OnTriggerEnter(Collider auto)
    {
        var id = auto.GetComponent<CarIdentity>();
        var tarkistaja = auto.GetComponent<CheckpointTarkistus>();
        if (tarkistaja.CanWin())
        {
            Debug.Log("Winner is " + id.car_name);
            tarkistaja.ResetLap();   
        }
    }
}
using System.Collections.Generic;
using UnityEngine;

public enum CarType { Player, Ai }
public class CarIdentity : MonoBehaviour
{
    public CarType type = CarType.Player;
    public string car_name = "Pelaaja";
}

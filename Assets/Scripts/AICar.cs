using UnityEngine;

public class AICar : MonoBehaviour
{

    public Transform[] waypoints; // Taulukko reittipisteistä

    private int currentWaypointIndex = 0; // Indeksi reittipisteeseen, jota kohti liikutaan tällä hetkellä

    public float speed = 10f; // AI-Auton nopeus

    public float rotationSpeed = 5f; // AI-Auton kääntymisnopeus

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Haetaan waypoints-taulukosta tämänhetkinen kohdepiste (seuraava piste reitillä), jota kohti auto liikkuu
        Transform target = waypoints[currentWaypointIndex];
        
        // Kohteen xz, pidä nykyinen y (ei nouse tai laske )
        Vector3 targetXZ = new Vector3(target.position.x, transform.position.y, target.position.z);

        // Suuntavektori kohteeseen (yksikkövektori)
        Vector3 direction = (targetXZ - transform.position).normalized;

        // Rotaatio kohti suuntaa
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        // Käänny pehmeästi (slerp) kohti kohdetta
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        
    }
}

using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    //pelaajan auton nopeus
    public float speed = 10f;

    //Pelaajan auton kääntymisnopeus
    public float turnSpeed = 50f;    

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameRunning)
        {
            //Luetaan pystysuuntainen liike
            float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            //Luetaan vaakasuuntainen liike
            float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

            // liikutetaan autoa eteen tai taakse Z-suunnassa ("forward" Unityssa)
            transform.Translate(Vector3.forward * move);

            //Käännetään autoa vasemmalle tai oikealle Y-akselin ympäri ("up" Unityssa)
            transform.Rotate(Vector3.up * turn);
        }
    }
}

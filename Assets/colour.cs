using UnityEngine;
using System.Collections;

public class CameraBackGround : MonoBehaviour
{

    private GameObject playerMovement;

    public Color backgroundSky = Color.blue;
    public Color backgroundSpace = Color.black;

    private float transfer = 10f;
    private float deltaTime = 0f;

    void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        if (playerMovement.transform.position.y >= 10f)
        {
            dayToNight();
        }
        else if (playerMovement.transform.position.y > 2f && playerMovement.transform.position.y < 10f)
        {
            nightToDay();
        }

    }

    void dayToNight()
    {
        deltaTime += Time.deltaTime;
        GetComponent<Camera>().backgroundColor = Color.Lerp(backgroundSky, backgroundSpace, deltaTime);
    }

    void nightToDay()
    {
        deltaTime += Time.deltaTime;
        GetComponent<Camera>().backgroundColor = Color.Lerp(backgroundSpace, backgroundSky, deltaTime);
    }
}
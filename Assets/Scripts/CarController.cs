using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const int IDLE = 0;
    private const int STARTING = 1;
    private const int MOVING = 2;

    [SerializeField] private AudioSource audioSource;
    private float timeToStartAudio = 4.0f;
    private float timeToStartMoving = 9.0f;
    private int state = IDLE;
    private float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state){
            case IDLE:
                if (Time.time > timeToStartAudio){
                    audioSource.Play();
                    state = STARTING;
                }
                break;
            case STARTING:
                if (Time.time > timeToStartMoving)
                    state = MOVING;
                break;
            case MOVING:
                speed += (Time.time - timeToStartMoving) / 100.0f;
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                break;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Controller : MonoBehaviour
{
    [SerializeField] private FadeInOut fadeInOutController;

    private float timeToFadeOut = 13.0f;
    private bool hasFadedOut = false;


    // Update is called once per frame
    void Update(){
        if (!hasFadedOut && Time.time > timeToFadeOut){
            fadeInOutController.FadeOut();
            hasFadedOut = true;
        }
    }
}

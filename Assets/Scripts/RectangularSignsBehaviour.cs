using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangularSignsBehaviour : MonoBehaviour
{
    public Material signMaterial;
    public float stillTime;
    public float scrollingSpeed;
    private float nextActionTime;
    private int nextImage;
    // Start is called before the first frame update
    void Start()
    {
        signMaterial.mainTextureOffset = new Vector2(0,0);
        nextActionTime = Time.time + stillTime;
        nextImage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextActionTime){
            nextActionTime = Time.time + stillTime;
            nextImage += 1;
            if (nextImage > 3){
                nextImage = 1;
                signMaterial.mainTextureOffset = new Vector2(0,0);
            }
        }
        if (signMaterial.mainTextureOffset.y > -nextImage/3f){
            signMaterial.mainTextureOffset = new Vector2(0,signMaterial.mainTextureOffset.y - scrollingSpeed);
            if (signMaterial.mainTextureOffset.y < -nextImage/3f){
                signMaterial.mainTextureOffset = new Vector2(0,-nextImage/3f);
            }
        }
    }
}

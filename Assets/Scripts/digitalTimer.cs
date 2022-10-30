using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digitalTimer : MonoBehaviour
{
    public Texture2D[] textures;
    private float nextChange;
    private int currentImage;
    private Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        currentImage = 0;
        nextChange = Time.time + 1f;
        gameObject.GetComponent<MeshRenderer>().material.SetTexture("_EmissionMap", textures[currentImage]); //GetComponent<>.Material = textures[currentImage];
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextChange){
            nextChange = nextChange + 1;
            currentImage = (currentImage + 1)%textures.Length;
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_EmissionMap", textures[currentImage]);
        }
    }
}

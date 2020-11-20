using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Start is called before the first frame update
  
    [SerializeField] float backgroundScrollSpeed = -0.05f;
    Material myMaterial;
    Vector2 offSet;
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(backgroundScrollSpeed, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime* 0.01f;
    }
}


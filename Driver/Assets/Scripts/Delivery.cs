using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage = false;

    SpriteRenderer spriteRenderer; 

    [SerializeField]
    Color32 hasPackageColor = new Color32(1,1,1,1);

    [SerializeField]
    Color32  noPackageColor = new Color32(1,1,1,1);

    [SerializeField]
    float destroyPackageDelay = 1f;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }


    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I Collided with " + other.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyPackageDelay);
            spriteRenderer.color = hasPackageColor;
        }
        
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered package!");
            hasPackage = false; 
            spriteRenderer.color = noPackageColor;
        }
    }
}

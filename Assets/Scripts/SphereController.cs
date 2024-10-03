using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update

    float val = 1000f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // another movement function
        // Input.GetAxisRaw("Horizontal") * speed 
        Vector3 cur = gameObject.GetComponent<Rigidbody>().velocity;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(System.Math.Clamp(cur.x - 0.1f, -val, val), cur.y, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(System.Math.Clamp(cur.x + 0.1f, -val, val), cur.y, 0);
        }
    }
}

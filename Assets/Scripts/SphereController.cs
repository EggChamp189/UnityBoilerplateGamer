using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cur = gameObject.GetComponent<Rigidbody>().velocity;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(System.Math.Clamp(cur.x - 0.1f, -6f, 6f), cur.y, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(System.Math.Clamp(cur.x + 0.1f, -6f, 6f), cur.y, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update

    float val = 10f;
    bool ableToJump = false;
    public ScoreManager score;

    // Update is called once per frame
    void Update()
    {
        // another movement function
        // Input.GetAxisRaw("Horizontal") * speed 
        Vector3 cur = gameObject.GetComponent<Rigidbody>().velocity;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            if (cur.x >= -val) {
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(cur.x - 0.1f, cur.y, 0);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (cur.x <= val)
            {
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(cur.x + 0.1f, cur.y, 0);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            if (ableToJump)
            {
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(cur.x, 6.5f, 0);
                ableToJump = false;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (cur.y > -20f)
            {
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(cur.x, -20f, 0);
            }
        }
        if (transform.position.y <= -35)
        {
            SceneManager.LoadScene("UnityBoilerGame");
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            ableToJump = true;
        }
        if (collision.collider.tag == "Spike") {
            SceneManager.LoadScene("UnityBoilerGame");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            score.IncreaseScore();
            Destroy(other.gameObject);
        }
    }
}

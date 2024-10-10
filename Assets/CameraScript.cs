using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        gameObject.transform.position = new Vector3(playerPos.x, playerPos.y, -10);
    }
}

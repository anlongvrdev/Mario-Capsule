using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    private Vector3 playerCameraVector3;

    // Start is called before the first frame update
    void Start()
    {
        playerCameraVector3 = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - playerCameraVector3;
    }
}

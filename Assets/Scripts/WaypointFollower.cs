using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointindex = 0;

    [SerializeField] float speed = 1;
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,waypoints[currentWaypointindex].transform.position) < .1f)
        {
            currentWaypointindex++;
            if(currentWaypointindex >= waypoints.Length)
            {
                currentWaypointindex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointindex].transform.position, speed * Time.deltaTime);
    }
}

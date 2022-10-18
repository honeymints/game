using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWayPointIndex = 0;
    private Animator anim;

    [SerializeField] private float speed = 2f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
       
        if(Vector2.Distance(waypoints[currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= waypoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);
    }
}

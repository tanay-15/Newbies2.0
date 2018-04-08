using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCscript : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    private float waitTime;
    public float startWaitTime;
    Transform currentPatrolPoint;
    int randomSpot;

	// Use this for initialization
	void Start () {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, patrolPoints.Length);
        
       // currentPatrolPoint = patrolPoints[currentPatrolIndex];
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[randomSpot].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolPoints[randomSpot].position) < 0.2f)
        {
            if(waitTime <=0)
            {
                randomSpot = Random.Range(0, patrolPoints.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        //transform.Translate(Vector2.right * Time.deltaTime * speed);
        //if(Vector3.Distance(transform.position,currentPatrolPoint.position) < 0.1f)
        //{
        //    if(currentPatrolIndex +1 < patrolPoints.Length)
        //    {
        //        currentPatrolIndex++;
        //    }
        //    else
        //    {
        //        currentPatrolIndex = 0;
        //    }
        //    currentPatrolPoint = patrolPoints[currentPatrolIndex];
        //}

        //Turn to face the current patrol point
        //finding the        //Vector2 patrolPointDir = currentPatrolPoint.position - transform.position;
        ////figure out the rotation in degrees that we need to turn towards
        //float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x)* Mathf.Rad2Deg + 90f;
        ////Made the rotation  that we need to face

        //Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        ////Apply the rotation to out transform
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 90f); direction vector that points to the patrol point

	}
}

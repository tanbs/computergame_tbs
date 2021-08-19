using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 1;
    public Animator animator;
    // Start is called before the first frame update
   private void followTarget()
    {
        if(target != null)
        {
            Vector3 distance = target.position - transform.position;

            if((distance.x < 0.1) && (distance.x > -0.1))
            {
                transform.Translate(new Vector3(0, distance.y, 0) * moveSpeed * Time.deltaTime);

                if (distance.y > 0)
                    animator.SetInteger("moveDir", 3);
                else
                    animator.SetInteger("moveDir", 4);
            }
            else
            {
                transform.Translate(new Vector3(distance.x, 0, 0) * moveSpeed * Time.deltaTime);
                if (distance.x > 0)
                    animator.SetInteger("moveDir", 1);
                else
                    animator.SetInteger("moveDir", 2);
            }
        }
    }

     void Update()
    {
        followTarget();
    }
}

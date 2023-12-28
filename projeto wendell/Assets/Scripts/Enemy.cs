using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Variables")]
    public float movSpeed;
    //public float fallSpeed;
    [Header("Others")]
    public Transform[] patrolPoints;
    public int destination;
    //public Transform deathPoint;
    public Rigidbody2D rig;
    [Header("Booleans")]
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBetweenPoints();


    }

    void OnMouseDown()
    {
        movSpeed = 0;
        isDead = true;

        if (isDead)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
        rig.gravityScale = 1;
        yield return new WaitForSeconds(6);
        Destroy(gameObject);
    }
    void MoveBetweenPoints()
    {
        if (destination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, movSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[0].position) == 0)
            {
                destination = 1;
            }
        }
        if (destination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, movSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[1].position) == 0)
            {
                destination = 2;
            }
        }
        if (destination == 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[2].position, movSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[2].position) == 0)
            {
                destination = 3;
            }
        }
        if (destination == 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[3].position, movSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[3].position) == 0)
            {
                destination = 4;
            }
        }
        if (destination == 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[4].position, movSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[4].position) == 0)
            {
                destination = 5;
            }
        }
    }
}

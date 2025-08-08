using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isopod : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;

    bool reached;
        
    // Update is called once per frame
    void FixedUpdate()
    {
        if (reached) return;
        GetComponent<Rigidbody2D>().MovePosition((target.position - transform.position).normalized * Time.deltaTime * speed + transform.position);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter " + collision.gameObject.name);

        if (collision.transform == target)
        {
            reached = true;
        }
    }


}

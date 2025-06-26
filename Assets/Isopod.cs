using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isopod : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;

    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator Move()
    {
        Debug.Log("Hi");
        
        while(Vector3.Distance(transform.position, target.position) > 0.1f)
        {
            transform.position = (target.position - transform.position).normalized * Time.deltaTime * speed + transform.position;

            yield return null;
        }
    }

}

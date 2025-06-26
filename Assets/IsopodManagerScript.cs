using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsopodManagerScript : MonoBehaviour
{
    public Transform target;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            var isopod = Instantiate(prefab, new Vector3(-1.45f, -0.19f, 0), Quaternion.identity);

            isopod.GetComponent<Isopod>().target = target;

            var spawn = Random.onUnitSphere * 2.5f;
            spawn.z = 0;
            isopod.transform.position = spawn;
        }
    }
}

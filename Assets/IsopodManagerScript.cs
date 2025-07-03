using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsopodManagerScript : MonoBehaviour
{
    public Transform target;
    public GameObject prefab;

    public void CreateIsopods(Isopod isopod)
    {
        var copy = Instantiate(isopod, new Vector3(-1.45f, -0.19f, 0), Quaternion.identity);

        copy.target = target;

        var spawn = Random.onUnitSphere * 2.5f;
        spawn.z = 0;
        copy.transform.position = spawn;
    }
}

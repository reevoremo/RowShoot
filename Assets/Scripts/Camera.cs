using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject player;
    private float distanceCamera;
    // Update is called once per frame
    void Start()
    {
        distanceCamera = transform.position.z - player.transform.position.z;   
    }
    void Update()
    {

        Transform t = GetComponent<Transform>();

        Vector3 position = t.position;
        position.x = player.transform.position.x;
        position.z = player.transform.position.z + distanceCamera;
        t.position = position;

    }
}

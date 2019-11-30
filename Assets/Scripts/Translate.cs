using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{

    public float speed;
    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();

        Vector3 movement = new Vector3();

        movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        t.Translate(movement);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public KeyCode fireButton;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(fireButton))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}

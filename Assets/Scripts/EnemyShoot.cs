using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float shootingInterval = 5f;
    private float counter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        counter = shootingInterval;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0f)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            counter = shootingInterval;
        }
        
    }
}

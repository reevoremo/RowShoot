using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHero : MonoBehaviour
{
    public GameObject hero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var targetRotation = Quaternion.LookRotation(hero.transform.position - transform.position);
        var str = Mathf.Min(0.5f * Time.deltaTime, 1);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, str);
    }
}

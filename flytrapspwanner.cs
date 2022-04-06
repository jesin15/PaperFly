using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flytrapspwanner : MonoBehaviour
{
    public float timer;
    public float maxtime;
    public float height;
    public GameObject flytrap;
    public float destroytime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxtime)
        {
            GameObject newtrap = Instantiate(flytrap);
            newtrap.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newtrap, destroytime);
            timer = 0;
        }
        timer +=Time.deltaTime;
       
    }
}

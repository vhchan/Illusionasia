using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour
{
    public GameObject boulder;
    float time;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.fixedUnscaledTime;
        timer = time + 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.fixedUnscaledTime;
        if (timer <= time)
        {
            Instantiate(boulder, transform.position, Quaternion.identity);
            timer = time + Random.Range(4.0f, 8.0f);
        }
    }
}

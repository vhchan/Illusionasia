using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 right;
    private Vector3 left;
    private Vector3 target;
    private float speed;// = 4f;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        Vector3 offset = new Vector3(8, 0, 0);
        right = pos + offset;
        left = pos - offset;
        Vector3[] array = new Vector3[2];
        array[0] = right; array[1] = left;
        int num = Random.Range(0, 2);
        target = array[num];
        speed = Random.Range(3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
        if (transform.position == right)
        {
            target = left;
        }
        else if (transform.position == left)
        {
            target = right;
        }
    }
}

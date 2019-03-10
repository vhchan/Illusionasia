using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour
{
    private Vector3 target;
    protected float speed = 2.0f;
    private Vector3 scale;
    private Vector3 scaleOpposite;
    // Start is called before the first frame update
   protected virtual void Start()
    {
        int ranX = Random.Range(19, -19);
        int ranY = Random.Range(1, -6);
        target = new Vector3(ranX, ranY, -1);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            int ranX = Random.Range(19, -19);
            int ranY = Random.Range(1, -6);
            target = new Vector3(ranX, ranY, -1);
        }
    }
}

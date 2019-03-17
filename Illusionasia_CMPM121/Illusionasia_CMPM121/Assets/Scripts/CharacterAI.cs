using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour
{
    protected Vector3 target;
    protected float speed = 2.0f;
    private Vector3 scale;
    private Vector3 scaleOpposite;
    // Start is called before the first frame update
   protected virtual void Start()
    {
        int ranX = Random.Range(18, -18);
        int ranY = Random.Range(1, -6);
        target = new Vector3(ranX, ranY, -1);
        scaleOpposite = transform.localScale;
        scale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        directionCheck(target.x, transform.position.x);
        if (transform.position == target)
        {
            int ranX = Random.Range(19, -19);
            int ranY = Random.Range(1, -6);
            target = new Vector3(ranX, ranY, -1);
        }
    }

    protected virtual void directionCheck(float target1, float pos)
    {
        if (target1 >= 0)
        {
            if (pos >= 0)
            {
                if (target1 >= pos) { transform.localScale = scale; }
                else if (target1 <= pos) { transform.localScale = scaleOpposite; }
            }
            else if (pos <= 0) { transform.localScale = scale; }
        }
        else if (target1 <= 0)
        {
            if (pos >= 0) { transform.localScale = scaleOpposite; }
            else if (pos <= 0)
            {
                if (target1 >= pos) { transform.localScale = scale; }
                else if (target1 < pos) { transform.localScale = scaleOpposite; }
            }
        }
    }


}

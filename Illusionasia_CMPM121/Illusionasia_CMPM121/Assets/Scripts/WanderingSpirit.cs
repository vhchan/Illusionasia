using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WanderingSpirit : CharacterAI
{
    private float time;
    private float timer;
    public GameObject spiritEssence;
    public Text currency;
    private int count = 0;

    protected override void Start()
    {
        base.Start();
        time = Time.fixedUnscaledTime;
        timer = Random.Range(10.0f, 20.0f) + time;

    }
    protected override void Update()
    {
        base.Update();
        time = Time.fixedUnscaledTime;
        if (timer <= time)
        {
            int chance = Random.Range(0, 10);
            timer = Random.Range(10.0f, 20.0f) + time;
            if (CharacterMovement.winPegasusLevel && chance > 7)
            {
                Instantiate(spiritEssence, transform.position, Quaternion.identity);
                count++;
                
            }
        }
        currency.text = "x " + count;
    }
}

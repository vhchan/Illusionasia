using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainScript : MonoBehaviour
{
    public ParticleSystem rain;
    // Start is called before the first frame update
    void Start()
    {
        var particles = rain.GetComponent<ParticleSystem>();
        particles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

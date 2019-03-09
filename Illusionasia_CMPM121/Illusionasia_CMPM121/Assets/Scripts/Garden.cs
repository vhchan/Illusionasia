using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Garden : MonoBehaviour
{
    public GameObject pegasus;
    public GameObject wanderingSpirit;
    // Start is called before the first frame update
    void Start()
    {
        pegasus.GetComponent<SpriteRenderer>().enabled = false;
        wanderingSpirit.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CharacterMovement.winPegasusLevel)
        {
            pegasus.GetComponent<SpriteRenderer>().enabled = true;
            wanderingSpirit.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    public void playLevel()
    {
        SceneManager.LoadScene("PegasusLevel");
    }
}

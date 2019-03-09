using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Button start;
    public Image image;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        hideButton();
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 1)
        {
            EndDialogue();
        }
        else if (sentences.Count == 0)
        {
            Debug.Log("Do something");
            SceneManager.LoadScene(1);
        }
        else
        {
            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
        }
        
    }

    void EndDialogue()
    {
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        image.GetComponent<Image>().gameObject.SetActive(false);
    }

    void hideButton()
    {
        start.GetComponent<Button>().gameObject.SetActive(false);
    }

    private void Update()
    {
        if (CharacterMovement.winPegasusLevel)
        {
            image.GetComponent<Image>().gameObject.SetActive(true);
        }
    }
}

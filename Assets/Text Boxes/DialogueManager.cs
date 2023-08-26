using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> Sentences;

    // Start is called before the first frame update
    void Start()
    {
        Sentences = new Queue<string>();
    }   

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Startinng conversation with: " + dialogue.Name);

        Sentences.Clear();

        foreach(string sentence in dialogue.Sentences)
        {
            Sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string Sentence = Sentences.Dequeue();
        Debug.Log(Sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
}
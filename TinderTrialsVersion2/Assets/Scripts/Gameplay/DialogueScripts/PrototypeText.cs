using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrototypeText : MonoBehaviour
{
    private Queue<string> sentences;
     void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting a convo with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        
    }
    public void displayNextSentence()
    {
        if (sentences.Count==0)
        {

        }
    }


}

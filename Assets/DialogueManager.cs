using UnityEngine;
using System.Collections.Generic;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    [SerializeField] int dialogueIndex;
    [SerializeField] TextMeshProUGUI dialogueText;
    [TextArea]
    [SerializeField] List<string> dialogue;
    private void Start()
    {
      dialogueText.text = dialogue[dialogueIndex];
    }

    public void NextDialogue()
    {
        dialogueIndex += 1;
        if(dialogueIndex >= dialogue.Count)
        {
            Debug.Log("No more dialogue");
        }
        else
        {
         dialogueText.text = dialogue[dialogueIndex];
        }
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialoguemanager : MonoBehaviour
{

    [SerializeField] GameObject UIElements;
    [SerializeField] Text dialogueTxt;
    [SerializeField] string[] DialogueNPC;
    [SerializeField] DialogueNPC NPCDialogueScript;
    int dialogueIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        NPCDialogueScript = other.gameObject.GetComponent<DialogueNPC>();
        if (NPCDialogueScript)
        {
            UIElements.SetActive(true);
            DialogueNPC = NPCDialogueScript.data.dialogueLines;
            ShowNextDialogueLine();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(false);
            dialogueIndex = 0;
        }
    }

    public void ShowNextDialogueLine()
    {
        if (dialogueIndex < DialogueNPC.Length)
        {
            dialogueTxt.text = DialogueNPC[dialogueIndex];
            dialogueIndex++;
        }
        else
        {

        }
    }

}
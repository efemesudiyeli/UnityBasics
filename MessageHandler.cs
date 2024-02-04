using System.Collections;
using TMPro;
using UnityEngine;


public class MessageHandler : MonoBehaviour
{
    //- Scriptable Object Referansı
    [SerializeField] private DialogueScriptableObject _dialogueScriptableObject;
    //-

    //UI
    [SerializeField] private TextMeshProUGUI dialogueText;

    private void Start()
    {
        StartCoroutine(DialogueLoop());
    }

    IEnumerator DialogueLoop()
    {
        if (_dialogueScriptableObject.text.Length < 1)
        {
            Debug.LogError("Text array is empty!");
            yield return null;
        }

        for (int i = 0; i < _dialogueScriptableObject.text.Length; i++)
        {
            dialogueText.text = _dialogueScriptableObject.text[i];
            if (i == _dialogueScriptableObject.text.Length - 1) i = -1;
            yield return new WaitForSeconds(2f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]

public class TypingEffect : MonoBehaviour
{
    private TextMeshProUGUI textComponent;
    private AudioSource audio;
    private string originalMessage;
    public bool isPrinting;
    public float timeBetweenLetters;
    // Start is called before the first frame update
    void Awake()
    {
        TryGetComponent(out textComponent);
        TryGetComponent(out audio);
        originalMessage = textComponent.text;
        textComponent.text = "";
    }

    // Update is called once per frame
    private void OnDisable()
    {
        textComponent.text = originalMessage;
        StopAllCoroutines();
    }
    private void OnEnable()
    {
        PrintMessage(originalMessage);
    }

    public void PrintMessage(string message)
    {
        if (gameObject.activeInHierarchy)
        {
            if (isPrinting) return;
            isPrinting = true;
            StartCoroutine(letterByLetter(message));
        }
    }

    IEnumerator letterByLetter(string letter)
    {
        string msg = "";
        foreach(var letter2 in letter)
        {
            msg += letter2;
            textComponent.text = msg;
            audio.Play();
            yield return new WaitForSeconds(timeBetweenLetters);
        }

        isPrinting = false;
        StopAllCoroutines();
    }
}

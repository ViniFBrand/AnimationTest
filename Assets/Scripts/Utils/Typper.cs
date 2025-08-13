using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = .05f;
    public float timeToUntype = 0f;

    public string sentence;

    private void Awake()
    {
        textMesh.text = "";
    }

    [NaughtyAttributes.Button]
    public void StartType()
    {
        StartCoroutine(Type(sentence));
    }

    [NaughtyAttributes.Button]
    public void StartUntype()
    {
        StartCoroutine(Untype(sentence));
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach(char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }

    IEnumerator Untype(string s)
    {
        string currentText = s;
        while (currentText.Length > 0)
        {
            currentText = currentText.Substring(0, currentText.Length - 1);
            textMesh.text = currentText;
            yield return new WaitForSeconds(timeToUntype);
        }    
    }
}

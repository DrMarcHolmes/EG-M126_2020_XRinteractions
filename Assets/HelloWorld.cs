using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public TMP_Text m_text; 
    
    // Start is called before the first frame update
    void Start()
    {
        //m_text = GetComponent<TextMeshPro>();
        m_text.text = "hello VR MSc";
        print("Hello Console");
        Debug.Log("hello debug");
        Debug.LogWarning("this is a possible problem to have");
        Debug.LogError("this should have happened");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

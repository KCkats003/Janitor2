using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CleaningVal : MonoBehaviour
{

    private int Cleaningval;
    public TMP_Text m_TextComponent;
    string valstring; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cleaningval = GameObject.Find("Player").GetComponent<PlayerMovement>().collected;
        valstring = Cleaningval.ToString();
        // m_TextComponent.text = Cleaningval;
        m_TextComponent.text = valstring;
    }
}

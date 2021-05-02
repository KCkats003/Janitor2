using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject diescreen;
    public GameObject winscreen;
    public GameObject instructions;
    // public PlayerMovement PlayerMovement;
    bool died1;
    private int Cleaningval;

    // Start is called before the first frame update
    void Start()
    {
        diescreen.SetActive(false);
        winscreen.SetActive(false);
        instructions.SetActive(true);
        Time.timeScale = 0; 
        //   PlayerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();


    }

    // Update is called once per frame
    void Update()
    {
        died1 = GameObject.Find("Player").GetComponent<PlayerMovement>().died;
        Cleaningval = GameObject.Find("Player").GetComponent<PlayerMovement>().collected;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (Input.GetKeyDown(KeyCode.Return)|| Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey("enter"))
        {
            instructions.SetActive(false);
            Time.timeScale = 1;
        }


        if (died1) {
            diescreen.SetActive(true);
        }

        if (Cleaningval > 20)
        {
            winscreen.SetActive(true);
        }
    }
}

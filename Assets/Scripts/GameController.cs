using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject diescreen;
    public GameObject winscreen;
   public PlayerMovement PlayerMovement;
    bool died1; 

    // Start is called before the first frame update
    void Start()
    {
        diescreen.SetActive(false);
        winscreen.SetActive(false);
        PlayerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        

    }

    // Update is called once per frame
    void Update()
    {
        died1 = GameObject.Find("Player").GetComponent<PlayerMovement>().died;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (died1) {
            diescreen.SetActive(true);
        }
    }
}

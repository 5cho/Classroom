using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public LogicScript logic;
    private bool isCopying = false;
    
    public float scoreRate = 10f;
    private float nextScoreTime = 0f;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void Update()
    {
        if(Time.time >= nextScoreTime)
        {
            if (isCopying)
            {
                StartCoroutine(logic.scorePlus());
            }
            if(isCopying == false)
            {
                StartCoroutine(logic.scoreMinus());
            }
            nextScoreTime = Time.time + 1f / scoreRate;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Nerd"))
        {
            isCopying = true;
        }

        if (collision.CompareTag("WinArea"))
        {
            logic.Win();
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Nerd"))
        {
            isCopying = false;
        }
    }
}

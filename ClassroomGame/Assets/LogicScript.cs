using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class LogicScript : MonoBehaviour
{
    private int score = 0;
    private bool testCopied = false;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (score > 100 && testCopied == false)
        {
            Debug.Log("win");

            testCopied = true;
        }
    }
    public IEnumerator scorePlus()
    {
        if (testCopied == false)
        {
            score = score + 10;
            Debug.Log(score);
            yield return null;
        }
    }
    public IEnumerator scoreMinus()
    {
        if (score > 0 && score < 100)
        {
            score = score - 1;
            Debug.Log(score);
        }
        yield return null;
    }
    public void Win()
    {
        if (testCopied)
        {
            canvas.SetActive(true);
        }
    }
}

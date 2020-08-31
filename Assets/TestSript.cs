using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSript : MonoBehaviour
{
    public int number = 0;
    public Text text;

    private void Start()
    {
        text.text = number.ToString();
    }

    /*
    private void FixedUpdate()
    {
        number++;
        text.text = number.ToString();
    }
    */
    public void Pushing()
    {
        number++;
        text.text = number.ToString();
    }
    
}

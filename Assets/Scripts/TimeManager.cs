using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtCountDown;

    public float TimeToChange;
    public float waitTime;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        txtCountDown.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        txtTime.text = Time.time.ToString();
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();

        if (TimeToChange < Time.time)
        {
            counter--;
            if (counter != 0)
            {
                txtCountDown.text = counter.ToString();
                TimeToChange += waitTime;
            }
            else
            {
                txtCountDown.text = "GO!";
            }
        }
    }
}

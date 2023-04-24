using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // add new namespace

public class Timer : MonoBehaviour
{
    private Text MyText = null; // add new private variable
    private float TimeElapsed = 0f; //maintain the time that elapse over time.


    // Start is called before the first frame update
    void Awake()  // change start to awake , awake always happens first Than start.
    {
        MyText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Delta time always tells us how much time has passed in seconds since the previous frame. 
        // for every single frame, we're going to continually add the amount of time that has elapsed since the previous frame.
        TimeElapsed += Time.deltaTime; 
        //Now that we're updating the time, I want to display that in the text object that I have access to here.
        MyText.text = TimeElapsed.ToString("00"); // we put 2 00 becuase if we dont, we would get many decimal printed for every second.
    }
}

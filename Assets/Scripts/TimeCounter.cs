using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    TMP_Text timeText;
    float time=0;
    bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<TMP_Text>();
        timeText.SetText("START!");
    }

    // Update is called once per frame
    void Update()
    {
        if (!finish)
            timeText.SetText(Time.timeSinceLevelLoad.ToString());
        else timeText.SetText("you did it in: "+ time);
    }

    public void UpdateFinish(bool isFinished, float timeOfEnd)
    {
        finish = isFinished;
        time = timeOfEnd;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] public float countdown = 5.0f;
    public Text timeText;
    private bool isPose = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(isPose)
            {
                isPose = false;
            }else
            {
                isPose = true;
            }
        }
        
        if(isPose)
        {
            timeText.text = "ポーズ中";
            return;
        }
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f1") + "秒";
        if(countdown <= 0)
        {
            timeText.text = "時間になりました";
        }
    }
}

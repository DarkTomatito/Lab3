using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maincontroller : MonoBehaviour
{
    public Text score_text;
    public int score;
    public bool hit = false;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hit)
        {
            this.score++;
            this.hit = false;
            score_text.text = score.ToString();
        }

    }
}

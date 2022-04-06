using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalscore : MonoBehaviour
{
    TextMeshProUGUI scorefinal;
    void Start()
    {
        scorefinal = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scorefinal.text = "YOUR FINAL SCORE:" + score.scorevalue;
    }
}

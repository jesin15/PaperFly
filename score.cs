using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static int scorevalue=0;
    TextMeshProUGUI scorein;

    void Start()
    {
        scorein = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scorein.text = "Score=" + scorevalue;
    }
}

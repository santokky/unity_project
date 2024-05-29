using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    public TextMeshProUGUI score_text;

    private void Start()
    {
        score_text.text = "score : ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

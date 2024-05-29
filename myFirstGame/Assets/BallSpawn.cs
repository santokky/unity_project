using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallSpawn : MonoBehaviour
{
    public GameObject ball;
    Vector2 pos;
    float times = 1f;

    int score = 0;
    int score_value = 100;

    public TMP_Text score_text;

    private void Start()
    {
        score_text.text = "score : 0";
        pos = Input.mousePosition;
    }

    void Update()
    {
        score_text.text = "score : " + score;
        pos = Input.mousePosition;
        gameObject.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(pos).x, 4.5f);
        times += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && times >= 1f) {
            score += score_value;
            times = 0;
            Instantiate(ball, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}

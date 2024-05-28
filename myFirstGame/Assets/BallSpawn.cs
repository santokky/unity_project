using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject ball;
    Vector2 pos;
    // Update is called once per frame

    private void Start()
    {
        pos = Input.mousePosition;
    }

    void Update()
    {
        pos = Input.mousePosition;
        gameObject.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(pos).x, 4.5f);
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(ball, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}

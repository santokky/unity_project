using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumaction : MonoBehaviour
{
    CircleCollider2D cc;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CircleCollider2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.localScale == this.gameObject.transform.localScale) {
            Destroy(collision.gameObject);
            this.gameObject.transform.localScale *= 1.5f;
            //cc.radius *= 1.5f;
            sr.color = new Vector4(sr.color.r , sr.color.g / 1.5f, sr.color.b / 1.5f, 255);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public int score;
    private maincontroller control;
    private void Awake()
    {
        StartCoroutine(Kaboom());
        control = GameObject.FindObjectOfType<maincontroller>();
    }

    IEnumerator Kaboom()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            control.hit = true;
        }
    }

}

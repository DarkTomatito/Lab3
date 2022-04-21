using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -0.4f && this.transform.position.y == 0)
        {
            this.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (this.transform.position.x > 0.4f && this.transform.position.y == 0)
        {
            this.transform.Translate(-(speed * Time.deltaTime), 0, 0);
        }
        else if (this.transform.position.x == 0 && this.transform.position.y > 0.4f)
        {
            this.transform.Translate(0, -(speed * Time.deltaTime), 0);
        }
        else if (this.transform.position.x == 0 && this.transform.position.y < -0.4f)
        {
            this.transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}

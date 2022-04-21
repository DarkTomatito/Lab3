using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char : MonoBehaviour
{
    public GameObject slash;
    public Sprite idle;
    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;
    Touch touch;
    private Vector2 initialPosition;
    public Text state_text;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.GetComponent<SpriteRenderer>().sprite = right;
            Instantiate(slash, new Vector3(0.4f, 0, -1), this.transform.rotation);
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.GetComponent<SpriteRenderer>().sprite = left;
            Instantiate(slash, new Vector3(-0.4f, 0, -1), this.transform.rotation);
        } else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.GetComponent<SpriteRenderer>().sprite = up;
            Instantiate(slash, new Vector3(0, 0.3f, -1), this.transform.rotation);
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.GetComponent<SpriteRenderer>().sprite = down;
            Instantiate(slash, new Vector3(0, -0.5f, -1), this.transform.rotation);
        }
        

        if (Input.touchCount == 1)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                initialPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                Vector2 direction = touch.position - initialPosition;

                if (direction.x > 0.5f && direction.x >= Mathf.Abs(direction.y) * 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = right;
                    Instantiate(slash, new Vector3(0.4f, 0, -1), this.transform.rotation);
                    state_text.text = "Derecha";
                }
                else if (direction.x < -0.5f && direction.x <= -Mathf.Abs(direction.y) * 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = left;
                    Instantiate(slash, new Vector3(-0.4f, 0, -1), this.transform.rotation);
                    state_text.text = "Izquierda";
                }
                else if (direction.y > 0.5f && direction.y >= Mathf.Abs(direction.x) * 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = up;
                    Instantiate(slash, new Vector3(0, 0.3f, -1), this.transform.rotation);
                    state_text.text = "Arriba";

                }
                else if (direction.y < -0.5f && direction.y <= -Mathf.Abs(direction.x) * 2)
                {
                    this.GetComponent<SpriteRenderer>().sprite = down;
                    Instantiate(slash, new Vector3(0, -0.5f, -1), this.transform.rotation);
                    state_text.text = "Abajo";
                }
                else this.GetComponent<SpriteRenderer>().sprite = idle;

            }
            else this.GetComponent<SpriteRenderer>().sprite = idle;
        }
    }
}


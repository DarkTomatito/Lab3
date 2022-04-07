using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class botones : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [Header("Presed Varuables")]
    public bool upPressed = false;
    public bool downPressed = false;
    public bool leftPressed = false;
    public bool rightPressed = false;
    public Text state_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if(this.gameObject.name == "left")
        {
            leftPressed = false;
        } else if (this.gameObject.name == "up")
        {
            upPressed = false;
        } else if (this.gameObject.name == "down")
        {
            downPressed = false;
        } else if (this.gameObject.name == "right")
        {
            rightPressed = false;
        }
        state_text.text = "Idle";
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (this.gameObject.name == "left")
        {
            leftPressed = true;
            state_text.text = "Izquierda";
        }
        else if (this.gameObject.name == "up")
        {
            upPressed = true;
            state_text.text = "Arriba";
        }
        else if (this.gameObject.name == "down")
        {
            downPressed = true;
            state_text.text = "Abajo";
        }
        else if (this.gameObject.name == "right")
        {
            rightPressed = true;
            state_text.text = "Derecha";
        }
    }
}

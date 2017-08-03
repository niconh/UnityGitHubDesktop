using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;


public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image bgImg;
    private Image joystickImg;
    private RectTransform touchZone;
    private Vector3 inputVector;
    public bool GenerateOnClick;

     private void Start()
    {
        bgImg = gameObject.transform.GetChild(0).GetComponent<Image>();
        joystickImg = gameObject.transform.GetChild(1).GetComponent<Image>();
        touchZone = gameObject.transform.GetChild(2).GetComponent<RectTransform>();
    }


    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

            float x = (bgImg.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (bgImg.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            inputVector = new Vector3(x, 0, y);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            // Move Stick IMG

            joystickImg.rectTransform.anchoredPosition = new Vector3(inputVector.x * (bgImg.rectTransform.sizeDelta.x / 2),
                                                                     inputVector.z * (bgImg.rectTransform.sizeDelta.y / 2), 0);

        }

    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        Vector2 pos;


            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(touchZone, ped.position, ped.pressEventCamera, out pos) && GenerateOnClick)
            {
                bgImg.rectTransform.anchoredPosition = pos;
                joystickImg.rectTransform.anchoredPosition = pos;

                OnDrag(ped);
                //Enable vision de la gilada y cambiar de posicion
                //luego onDrag()
            }


        
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector3.zero;
        joystickImg.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float Horizontal()
    {
        if (inputVector.x != 0)
            return inputVector.x;
        else
            return Input.GetAxis("Horizontal");
    }

    public float Vertical()
    {
        if (inputVector.z != 0)
            return inputVector.z;
        else
            return Input.GetAxis("Vertical");
    }


}

using System;
using TouchScript.Gestures;
using TouchScript.Hit;
using UnityEngine;
using System.Collections;

public class Input_Handler : MonoBehaviour {

    public bool pressedDebug;
    public bool tapDebug;
    public MovementScript playerMovementScript;
    public PressGesture PressGesture;
    public ReleaseGesture ReleaseGesture;
    public TapGesture TapGesture;

    

    private void OnEnable()
    {
        if (PressGesture == null) { PressGesture = GetComponent<PressGesture>(); }
        PressGesture.Pressed += pressedHandler;

        if (ReleaseGesture == null) { ReleaseGesture = GetComponent<ReleaseGesture>(); }
        ReleaseGesture.Released += releasedHandler;

        if (TapGesture == null) { TapGesture = GetComponent<TapGesture>(); }
        TapGesture.Tapped += tappedHandler;
    }

    private void Update()
    {
        playerMovementScript.pressed = pressedDebug;  //update the Pressed Gesture on the movement script;
    

    }

    private void OnDisable()
    {
        PressGesture.Pressed -= pressedHandler;
        ReleaseGesture.Released -= releasedHandler;
        TapGesture.Tapped -= tappedHandler;
    }

    private void pressedHandler(object sender, EventArgs e)
    {
       pressedDebug = true;
    }

    private void tappedHandler(object sender, EventArgs e)
    {
        tapDebug = true;
        playerMovementScript.tapped = true;               //update the Tap Gesture on the movement script;
        StartCoroutine(Wait());
    }
             
    private void releasedHandler(object sender, EventArgs e)
    {   
        pressedDebug = false;
    }

    IEnumerator Wait()  // contador para desactivar tap,  el tiempo deberia coincidir con el valor de touchScript
    {
       yield return new WaitForSeconds(0.1f);
        tapDebug = false;

    }
}
   

       
    

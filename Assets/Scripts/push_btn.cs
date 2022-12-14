using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class push_btn : MonoBehaviour
{
    [SerializeField] private float thresHold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _joint;

    public UnityEvent onPressed, onReleased;

    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();

    }


    private void Update()
    {
        Debug.Log(GetValue() + thresHold);
        if(!_isPressed && GetValue() + thresHold> 1)
        {
            Pressed();
        }
        if (_isPressed && GetValue() + thresHold <= 0)
        {
            Released();
        }
    }

    private float GetValue() {
        var value = Vector3.Distance(_startPos,transform.localPosition);
        if (Math.Abs(value)<deadZone)
        {
            value = 0;
        }
        //Debug.Log(Mathf.Clamp(value, -1f, 1f));
        return Mathf.Clamp(value, -1f, 1f);
    }
    private void Pressed()
    {
        _isPressed = true;
        onPressed.Invoke();
        Debug.Log("pressed");
    }

    private void Released()
    {
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
    }
}

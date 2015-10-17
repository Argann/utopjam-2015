using System.Runtime.Remoting;
using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour
{
    public bool startActivated = false;
    private bool _isActive = false;


    public void Awake()
    {
        if (startActivated)
        {
            SetIsActive(true);
        }
    }


    public void Activate()
    {
        SetIsActive(true);
    }

    public void Desactivate()
    {
        SetIsActive(false);        
    }

    public bool GetIsActive()
    {
        return _isActive;
    }
    public void SetIsActive(bool b)
    {
        _isActive = b;
    }
}

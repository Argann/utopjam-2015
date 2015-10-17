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

		gameObject.SetActive (startActivated);
    }


    public void Activate()
    {
        SetIsActive(true);
		gameObject.SetActive (true);
    }

    public void Desactivate()
    {
        SetIsActive(false);
		gameObject.SetActive (false);
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

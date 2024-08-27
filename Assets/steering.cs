using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class steering : MonoBehaviour
{
    public steeringwheel wheel;


    private void Update()
    {
        print(wheel.value);
    }
}

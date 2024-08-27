using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Hands : MonoBehaviour
{
    [SerializeField] private InputActionProperty grabaction;
    [SerializeField] private Animator handanim;
    

    // Update is called once per frame
    void Update()
    {
        float garbvalue = grabaction.action.ReadValue<float>();
        handanim.SetFloat("Grip", garbvalue);
    }
}

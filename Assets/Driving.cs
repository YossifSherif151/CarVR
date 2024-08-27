using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private ActionBasedController rcontroller;
    [SerializeField] private ActionBasedController lcontroller;

    [SerializeField] private Rigidbody car_rb;


    private void OnEnable()
    {
        if (rcontroller != null && lcontroller != null)
        {
            rcontroller.activateAction.action.performed += righttriggerpressed;
            rcontroller.activateAction.action.canceled += righttriggerreleased;

            lcontroller.activateAction.action.performed += lefttriggerpressed;
            lcontroller.activateAction.action.canceled += lefttriggerreleased;
        }
    }

    private void OnDisable()
    {
        if (rcontroller != null && lcontroller != null)
        {
            rcontroller.activateAction.action.performed -= righttriggerpressed;
            rcontroller.activateAction.action.canceled -= righttriggerreleased;

            lcontroller.activateAction.action.performed -= lefttriggerpressed;
            lcontroller.activateAction.action.canceled -= lefttriggerreleased;
        }
    }


    private void righttriggerpressed(InputAction.CallbackContext context)
    {
        car_rb.velocity = new Vector3(0, 0, 5f);
    }


    private void righttriggerreleased(InputAction.CallbackContext context)
    {
        car_rb.velocity = Vector3.zero;
    }

    private void lefttriggerpressed(InputAction.CallbackContext context)
    {
        car_rb.velocity = new Vector3(0, 0, -5f);
    }


    private void lefttriggerreleased(InputAction.CallbackContext context)
    {
        car_rb.velocity = Vector3.zero;
    }
}

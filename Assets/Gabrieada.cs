using UnityEngine;
using UnityEngine.InputSystem;

public class Gabrieada : MonoBehaviour
{
    private Vector2 m_Position;
    //private MyActions m_Actions;

    private void Awake()
    {
        //m_actions = new MyActions();
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
    public void OnMove(InputAction.CallbackContext controller)
    {
        Vector3 movement = controller.ReadValue<Vector2>();
    }
}

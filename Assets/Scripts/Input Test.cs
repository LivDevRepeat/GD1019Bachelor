using UnityEngine;
using UnityEngine.InputSystem;
public class CSharpEvent : MonoBehaviour
{
    [SerializeField] InputActionReference test;
    void OnEnable()
    {
        test.action.performed += MyEventFunction;
    }
    void OnDisable()
    {
        test.action.performed  -= MyEventFunction;
    }
    void MyEventFunction(InputAction.CallbackContext value)
    {
        Debug.Log(value.action.name + (" was triggered"));
    }
}
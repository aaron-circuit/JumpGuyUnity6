using UnityEngine;
using UnityEngine.InputSystem;

public class UserInputJump : MonoBehaviour
{

    [SerializeField] private InputActionReference jumpAction;
    [SerializeField] private Transform targetTransform;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.action.WasPressedThisFrame())
        {
            targetTransform.SetLocalPositionAndRotation(targetTransform.localPosition + (Vector3.up * 2f), targetTransform.localRotation);
        }
    }
}

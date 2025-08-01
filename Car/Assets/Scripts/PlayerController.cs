using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 40;
    private float turnSpeed = 50;
    private InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveValue[1]);

        if (moveValue[1] > 0) transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveValue[0]);
        if (moveValue[1] < 0) transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * -moveValue[0]);
    }
}

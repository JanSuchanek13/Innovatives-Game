using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable(); 
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector2 move = playerInput.LowerBody.Move.ReadValue<Vector2>();
        Debug.Log("move-input " + move);
        
        
        //playerInput.Legs.Sprint.ReadValue<Vector2>();
        //if (playerInput.Legs.Sprint.ReadValue<Vector2>() == 1)
        if (playerInput.LowerBody.Sprint.triggered)
        {
            Debug.Log("Sprint");

        }
    }
}

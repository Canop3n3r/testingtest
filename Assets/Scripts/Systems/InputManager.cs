using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public bool JumpPressed { get; private set; }
    public bool InteractPressed { get; private set; }
    public Vector2 MoveInput { get; private set; }

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        MoveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        JumpPressed = Input.GetButtonDown("Jump");
        InteractPressed = Input.GetKeyDown(KeyCode.E);
    }
}
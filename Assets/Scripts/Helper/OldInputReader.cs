using UnityEngine;

public class OldInputReader : IInputReader
{
    Vector3 input;
    public Vector3 MoveDirection
    {
        get
        {
            input.x = Input.GetAxis(Constants.Old_InputSystem_Horizontal);
            input.y = Input.GetAxis(Constants.Old_InputSystem_Horizontal);

            return new Vector3(input.x, input.y, 0f);
        }
    }

    public bool KeyDown(KeyCode keyCode)
    {
        return Input.GetKeyDown(keyCode);
    }

    public bool KeyStay(KeyCode keyCode)
    {
        return Input.GetKey(keyCode);
    }

    public bool KeyUp(KeyCode keyCode)
    {
        return Input.GetKeyUp(keyCode);
    }
}
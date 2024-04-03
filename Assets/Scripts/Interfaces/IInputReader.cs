using UnityEngine;

public interface IInputReader
{
    public Vector3 MoveDirection { get; }    
    // public bool Jump(KeyCode keyCode);
    public bool KeyDown(KeyCode keyCode);
    public bool KeyStay(KeyCode keyCode);
    public bool KeyUp(KeyCode keyCode);
}
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] public Health health;
    [SerializeField] public Movement movement;
    [SerializeField] public Interact interact;

    public Transform feetPosition;
    public LayerMask layerMask;

    /// <summary>
    /// 0- Left, 1- Up, 2- Right, 3- Down
    /// </summary>
    public KeyCode[] player_MoveCode;

    /// <summary>
    /// X
    /// </summary>
    public KeyCode player_Aircross_Fire_and_IDLE;

    /// <summary>
    /// 0- Up, 1- Down 
    /// </summary>
    public KeyCode[] player_WeaponAngleCode;

}
public abstract class Base : MonoBehaviour
{
    [SerializeField] public Health health;
    [SerializeField] public Movement movement;
    [SerializeField] public Interact interact;
}

public class Player2 : Base
{
    public static Player2 Instance;
    private void Awake()
    {
        Instance = this;
    }

        
}

public class Player1 : Base
{
    public static Player1 Instance;
    private void Awake()
    {
        Instance = this;
    }


}
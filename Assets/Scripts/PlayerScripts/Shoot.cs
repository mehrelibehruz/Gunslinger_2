using UnityEngine;

public class Shoot : MonoBehaviour
{
    IInputReader _input;

    private void Start()
    {
        _input = new OldInputReader();
    }

    private void Update()
    {
        // Debug.DrawRay(Vector3.right, Vector3.left, Color.green);
        // Debug.DrawLine(Vector3.right, Vector3.left, Color.red);   


        // STATE MACHINE
        // switch ()
        // {


        // }   

        if (_input.KeyDown(Player.Instance.player_Aircross_Fire_and_IDLE)) // x
        {
            print("AA");

            Player.Instance.movement.doMove = false;
        }
        else if (_input.KeyStay(Player.Instance.player_Aircross_Fire_and_IDLE)) // x
        {
            if (_input.KeyDown(Player.Instance.player_WeaponAngleCode[0]))
            {
                // transform.Rotate(0, 0, transform.rotation.z + 10);
                // transform.Rotate(0, 0, Mathf.Clamp(transform.rotation.z, 0, 60));                

                // float newZAngle = Mathf.Clamp(transform.eulerAngles.z + 10f, 0, 60);
                // transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newZAngle);

                transform.localRotation *= Quaternion.Euler(0, 0, 10f);
            }
            if (_input.KeyDown(Player.Instance.player_WeaponAngleCode[1]))
            {
                // transform.Rotate(0, 0, transform.rotation.z - 10);
                // transform.Rotate(0, 0, Mathf.Clamp(transform.rotation.z, -60, 0) - 10);

                // float newZAngle = transform.eulerAngles.z - 10f; // 0 -10 = -10 + (-10) = 0
                // transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newZAngle);

                transform.localRotation *= Quaternion.Euler(0, 0, -10f);
            }
        }
        else if (_input.KeyUp(Player.Instance.player_Aircross_Fire_and_IDLE)) // x
        {
            ShootGun();
            Player.Instance.movement.doMove = true;
            // transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        }
    }

    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    // void ShootGun()
    // {
    //     Vector3 playerScale = Player.Instance.gameObject.transform.localScale;
    //     var gunObject = Instantiate(bullet, firePoint.position, transform.rotation);
    //     gunObject.transform.localScale = new Vector3(firePoint.localScale.x, bullet.transform.localScale.y, bullet.transform.localScale.z);


    //     // var plRB = Player.Instance.movement.gameObject.GetComponent<Rigidbody2D>();
    //     // if (plRB.velocity.x > 0)
    //     // {
    //     //     gunObject.transform.Rotate(0, 180, 0);
    //     // }
    //     // else
    //     // {
    //     //     gunObject.transform.Rotate(0, 180, 0);
    //     // }
    // }

    void ShootGun()
    {
        Vector3 playerScale = Player.Instance.gameObject.transform.localScale;
        var gunObject = Instantiate(bullet, firePoint.position, this.transform.rotation); // this = > pistol
        gunObject.transform.localScale = new Vector3(firePoint.localScale.x, bullet.transform.localScale.y, bullet.transform.localScale.z);

        float angle = playerScale.x == 1f ? 0f : 180f;
        gunObject.transform.Rotate(0, angle, 0);
    }
}
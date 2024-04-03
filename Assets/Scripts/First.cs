using UnityEngine;

public class First : MonoBehaviour
{
    public static First instance;

    private void Awake() {
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
        DontDestroyOnLoad(instance);
    }
}

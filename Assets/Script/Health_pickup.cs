using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior GameManager;

    void Start()
    {
        // Tambahkan Ini (3.4) - Cari Game Manager otomatis
        GameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item collected!");
        
            if (GameManager != null)
            {
                    GameManager.Items += 1;
            }
        }

        
    }
}
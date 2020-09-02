using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.name == "Player")
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}

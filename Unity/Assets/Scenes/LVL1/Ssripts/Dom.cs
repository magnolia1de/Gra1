using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dom : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(6);
    }
}

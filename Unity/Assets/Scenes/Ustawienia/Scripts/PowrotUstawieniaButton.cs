using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PowrotUstawieniaButton : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(PlayGame);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
}

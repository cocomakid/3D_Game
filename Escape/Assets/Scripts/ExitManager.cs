using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitManager : MonoBehaviour
{
    public GameObject Panel;

    public void MainButton()
    {
        SceneManager.LoadScene("Main");
    }
}

using UnityEngine;
using StarterAssets;

public class OverPlane : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            FindFirstObjectByType<ThirdPersonController>().enabled = false;
        }
    }
}
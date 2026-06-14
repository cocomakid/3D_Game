using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] GameObject settingPanel;

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            bool isOpen = settingPanel.activeSelf;
            settingPanel.SetActive(!isOpen);

            if (isOpen)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                FindFirstObjectByType<ThirdPersonController>().enabled = true;
                Time.timeScale = 1f; // 시간 재개
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                FindFirstObjectByType<ThirdPersonController>().enabled = false;
                Time.timeScale = 0f; // 시간 정지
            }
        }
    }
}
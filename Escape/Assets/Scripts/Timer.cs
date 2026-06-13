using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using StarterAssets;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] GameObject gameOverPanel; // Canvas의 Panel을 여기에 드래그앤드롭

    private bool isGameOver = false;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (!isGameOver)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            isGameOver = true;
            gameOverPanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // 캐릭터 움직임 정지
            FindObjectOfType<ThirdPersonController>().enabled = false;
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
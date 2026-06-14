using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TMP_Text coinText;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject jumpScarePanel; // 점프스케어 패널 드래그앤드롭
    private int coinCount = 0;

    public void AddCoin()
    {
        coinCount++;
        coinText.text = coinCount.ToString() + " / 8";

        if (coinCount == 7)
        {
            StartCoroutine(JumpScare());
        }

        if (coinCount >= 8)
        {
            winPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            FindFirstObjectByType<StarterAssets.ThirdPersonController>().enabled = false;
        }
    }

    IEnumerator JumpScare()
    {
        jumpScarePanel.SetActive(true);  // 점프스케어 사진 표시
        FindAnyObjectByType<AudioManager>().PlaySFX(FindAnyObjectByType<AudioManager>().Entity);
        yield return new WaitForSeconds(2f); // 2초 후 사라짐
        jumpScarePanel.SetActive(false);
    }
}
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource runSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip backGround;
    public AudioClip Click;
    public AudioClip Score;
    public AudioClip Walk;
    public AudioClip Run;
    public AudioClip Jump;
    public AudioClip Entity;

    private void Start()
    {
        musicSource.clip = backGround;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayRunSound(AudioClip clip)
    {
        // 다른 클립으로 바뀔 때만 교체 (Walk↔Run 전환 시 자연스럽게)
        if (runSource.clip != clip)
        {
            runSource.clip = clip;
            runSource.loop = true;
            runSource.Play();
        }
    }
    public void StopRunSound()
    {
        runSource.Stop();
        runSource.clip = null;
    }
    public void PlayClickSound()
    {
        SFXSource.PlayOneShot(Click);
    }
}
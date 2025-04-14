using UnityEngine;
using UnityEngine.UI;

public class ObjectAudioManager : MonoBehaviour
{
    public AudioSource objectAudioSource;
    public Image playPauseIcon;
    public Sprite playSprite;
    public Sprite pauseSprite;

    private void Start()
    {
        if (objectAudioSource == null)
            Debug.LogError("AudioSource is not assigned.");
        if (playPauseIcon == null)
            Debug.LogError("PlayPauseIcon Image is not assigned.");
        if (playSprite == null || pauseSprite == null)
            Debug.LogError("Play or Pause Sprite is not assigned.");

        UpdateIcon(); // Ensure icon starts in play (paused) state
    }

    public void TogglePlayPause()
    {
        if (objectAudioSource == null)
        {
            Debug.LogError("AudioSource is not assigned.");
            return;
        }

        if (objectAudioSource.isPlaying)
        {
            objectAudioSource.Pause();
            Debug.Log("Audio paused.");
        }
        else if (objectAudioSource.clip != null)
        {
            objectAudioSource.Play();
            Debug.Log("Audio playing.");
        }
        else
        {
            Debug.LogWarning("No audio clip assigned to the AudioSource.");
        }

        UpdateIcon();
    }

    public void SetNewClip(AudioClip newClip)
    {
        if (objectAudioSource == null)
        {
            Debug.LogError("AudioSource is not assigned.");
            return;
        }

        if (newClip != null)
        {
            objectAudioSource.clip = newClip;
            objectAudioSource.Stop(); // Keep it paused until play is pressed
            Debug.Log("New audio clip set.");
            UpdateIcon(); // Reset icon to play since it's paused
        }
        else
        {
            Debug.LogWarning("Attempted to set a null AudioClip.");
        }
    }

    private void UpdateIcon()
    {
        if (playPauseIcon == null)
        {
            Debug.LogError("PlayPauseIcon Image is not assigned.");
            return;
        }

        if (objectAudioSource != null && objectAudioSource.isPlaying)
        {
            playPauseIcon.sprite = pauseSprite;
        }
        else
        {
            playPauseIcon.sprite = playSprite;
        }
    }
}

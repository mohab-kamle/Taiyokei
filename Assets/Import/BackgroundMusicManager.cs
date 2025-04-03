using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    private static BackgroundMusicManager instance;
    private AudioSource audioSource;

    void Awake()
    {
        // Ensure only one instance of the background music exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Get or add an AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // Adds missing AudioSource
        }

        audioSource.loop = true; // Enable looping
        audioSource.playOnAwake = true; // Ensure it starts playing
        audioSource.Play();
    }
}

using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public AudioClip objectClip;

    public void OnObjectClicked()
    {
        ObjectAudioManager manager = Object.FindFirstObjectByType<ObjectAudioManager>();
        if (manager != null && objectClip != null)
        {
            manager.SetNewClip(objectClip);
        }
    }
}
// This script is attached to the object that will be clicked. It finds the ObjectAudioManager and sets the new clip when clicked.
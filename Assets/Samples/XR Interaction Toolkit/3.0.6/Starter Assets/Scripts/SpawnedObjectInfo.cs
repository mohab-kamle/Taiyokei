using UnityEngine;

public class SpawnedObjectInfo : MonoBehaviour
{
    [Tooltip("The description or text associated with this object.")]
    [SerializeField]
    private string m_Description;

    /// <summary>
    /// The description or text associated with this object.
    /// </summary>
    public string Description
    {
        get => m_Description;
        set => m_Description = value;
    }

    [Tooltip("The audio clip associated with this object.")]
    [SerializeField]
    private AudioClip m_ObjectClip;

    /// <summary>
    /// The audio clip associated with this object.
    /// </summary>
    public AudioClip ObjectClip
    {
        get => m_ObjectClip;
        set => m_ObjectClip = value;
    }
}
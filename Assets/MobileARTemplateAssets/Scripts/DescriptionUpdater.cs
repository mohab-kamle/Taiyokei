using UnityEngine;
using TMPro; // For TextMeshPro support
using UnityEngine.UI; // For Unity's built-in Text component

public class DescriptionUpdater : MonoBehaviour
{
    // The GameObject that contains the text component
    [SerializeField]
    public GameObject m_DescriptionObject;

    // Function to update the description text with the given description
    public void UpdateDescription(string description)
    {
        if (m_DescriptionObject != null)
        {
            // Try to get a TextMeshProUGUI component
            var tmpText = m_DescriptionObject.GetComponent<TextMeshProUGUI>();
            if (tmpText != null)
            {
                tmpText.text = description;
                return;
            }

            // If no TextMeshProUGUI is found, try to get a Unity UI Text component
            var uiText = m_DescriptionObject.GetComponent<Text>();
            if (uiText != null)
            {
                uiText.text = description;
                return;
            }

            Debug.LogWarning("No text component found on the assigned GameObject.");
        }
        else
        {
            Debug.LogWarning("Description object is not assigned.");
        }
    }
}

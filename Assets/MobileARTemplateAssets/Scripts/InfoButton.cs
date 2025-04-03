using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Represents an information button with a tooltip and an action.
/// </summary>
public class InfoButton : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The button component for the info button.")]
    Button m_InfoButton;

    /// <summary>
    /// The button component for the info button.
    /// </summary>
    public Button infoButton
    {
        get => m_InfoButton;
        set => m_InfoButton = value;
    }

    [SerializeField]
    [Tooltip("The tooltip text to display when the info button is hovered.")]
    string m_TooltipText;

    /// <summary>
    /// The tooltip text to display when the info button is hovered.
    /// </summary>
    public string tooltipText
    {
        get => m_TooltipText;
        set => m_TooltipText = value;
    }
}

public class ARObjectInfo : MonoBehaviour
{
    [SerializeField] private Button infoButton;  // Reference to the Info button
    [SerializeField] private GameObject infoModal; // Reference to the Info modal

    private void Start()
    {
        if (infoButton != null)
        {
            infoButton.onClick.AddListener(ShowInfo);
        }

        if (infoModal != null)
        {
            infoModal.SetActive(false); // Hide the modal initially
        }
    }

    private void ShowInfo()
    {
        if (infoModal != null)
        {
            infoModal.SetActive(!infoModal.activeSelf); // Toggle modal visibility
        }
    }
}

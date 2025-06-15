/*
 * Author: Mei Yifan
 * Date: 14/6/2025
 * Description: Triggers a UI popup when the player's score reaches or exceeds a defined threshold.
 */

using UnityEngine;

/// <summary>
/// Monitors the player's score and activates a popup panel once the score threshold is met.
/// </summary>
public class ScorePopupTrigger : MonoBehaviour
{
    /// <summary>
    /// Reference to the PlayerBehaviour script to check the current score.
    /// </summary>
    [SerializeField] private PlayerBehaviour player;

    /// <summary>
    /// UI panel that is activated when the score threshold is reached.
    /// </summary>
    [SerializeField] private GameObject scorePopupPanel;

    /// <summary>
    /// The score value at which the popup should be triggered.
    /// </summary>
    [SerializeField] private int scoreThreshold = 80;

    /// <summary>
    /// Flag to ensure the popup is only shown once.
    /// </summary>
    private bool hasShownPopup = false;

    /// <summary>
    /// Checks every frame if the player's score reached the threshold to show the popup.
    /// </summary>
    void Update()
    {
        if (!hasShownPopup && player != null && player.GetScore() >= scoreThreshold)
        {
            ShowPopup();
        }
    }

    /// <summary>
    /// Activates the popup panel and sets the flag to prevent repeated showing.
    /// </summary>
    void ShowPopup()
    {
        if (scorePopupPanel != null)
        {
            scorePopupPanel.SetActive(true);
            hasShownPopup = true;
            //Debug.Log("Score reached 80! Popup shown.");
        }
    }
}

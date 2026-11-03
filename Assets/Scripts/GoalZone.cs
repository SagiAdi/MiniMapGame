using TMPro;
using UnityEngine;

/// <summary>
/// The maze exit. Shows a win message when the player touches it.
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class GoalZone : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private string winMessage = "You made it! You win!";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMover>() != null)
        {
            messageText.text = winMessage;
        }
    }
}
using UnityEngine;
using Projects.MegaSuperChallengeShot.Scripts;
namespace FlappyBirdClone
{
public class ScoreTrigger : MonoBehaviour
{
    private bool hasScored = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasScored && other.CompareTag("Player"))
        {
            hasScored = true;
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore();
            }
        }
    }
}

}
using UnityEngine;

public class ArcadeMachine : MonoBehaviour
{
    public string gameTitle = "RETRO BLAST";
    public ParticleSystem screenGlow;

    private bool playerNearby = false;

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            PlayArcadeGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
            Debug.Log($"Press E to play {gameTitle}!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) playerNearby = false;
    }

    private void PlayArcadeGame()
    {
        Debug.Log($"Launching {gameTitle}... (Hook this to load your actual game scene!)");
        // GameManager.Instance.StartGame();  // Uncomment when ready
        FindObjectOfType<ParticleSystem>()?.Play();
    }
}
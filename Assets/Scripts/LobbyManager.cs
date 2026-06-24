using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    [Header("Lobby Settings")]
    public GameObject[] arcadeMachines;
    public GameObject[] neonSigns;
    public GameObject[] posters;
    public Transform[] spawnPoints;

    public int numberOfDecorItems = 25;

    void Start()
    {
        GenerateLobbyDecor();
        Debug.Log("Arcade Lobby Generated - Welcome to the game!");
    }

    private void GenerateLobbyDecor()
    {
        // Spawn arcade machines
        for (int i = 0; i < 8; i++)
        {
            if (arcadeMachines.Length > 0)
            {
                Vector3 pos = new Vector3(Random.Range(-20f, 20f), 0, Random.Range(-15f, 15f));
                Instantiate(arcadeMachines[Random.Range(0, arcadeMachines.Length)], pos, Quaternion.Euler(0, Random.Range(0, 360), 0));
            }
        }

        // Spawn neon signs / lights
        for (int i = 0; i < 12; i++)
        {
            if (neonSigns.Length > 0)
            {
                Vector3 pos = new Vector3(Random.Range(-25f, 25f), Random.Range(3f, 8f), Random.Range(-20f, 20f));
                Instantiate(neonSigns[Random.Range(0, neonSigns.Length)], pos, Quaternion.identity);
            }
        }

        // Spawn posters / wall decor
        for (int i = 0; i < numberOfDecorItems; i++)
        {
            if (posters.Length > 0)
            {
                Vector3 pos = new Vector3(Random.Range(-28f, 28f), Random.Range(1f, 6f), Random.Range(-22f, 22f));
                Instantiate(posters[Random.Range(0, posters.Length)], pos, Quaternion.Euler(0, Random.Range(0, 360), 0));
            }
        }

        Debug.Log("Lobby fully decorated with arcade vibes!");
    }
}
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [Header("AI Settings")]
    public Transform player;
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public float moveSpeed = 3.5f;

    private NavMeshAgent agent;
    private Animator animator; // Optional for animations

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (agent == null) agent = gameObject.AddComponent<NavMeshAgent>();
        agent.speed = moveSpeed;

        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null) player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= detectionRange)
        {
            agent.SetDestination(player.position);

            if (distance <= attackRange)
            {
                Attack();
            }
        }
    }

    private void Attack()
    {
        Debug.Log("Enemy Attacks Player!");
        // TODO: Implement damage, animation trigger, cooldown
    }
}
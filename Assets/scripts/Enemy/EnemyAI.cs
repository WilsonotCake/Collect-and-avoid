using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    enum State { Patrol, Chase }
    State state;

    public Transform player;
    public Transform eye;
    public Transform[] waypoints;
    public LayerMask wallMask;
    public GameManager gameManager;
    public float sightRange = 8f;

    NavMeshAgent agent;
    int index;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (gameManager.State == GameManager.GameState.Lost)
        {
            agent.isStopped = true;
            return;
        }

        Vector3 direction = player.position - eye.position;

        bool seesPlayer = direction.magnitude < sightRange &&
                          !Physics.Raycast(eye.position, direction.normalized,
                              direction.magnitude, wallMask);

        if (seesPlayer)
            state = State.Chase;
        else
            state = State.Patrol;

        switch (state)
        {
            case State.Patrol:
                if (Vector3.Distance(transform.position,
                        waypoints[index].position) < 1f)
                {
                    index = (index + 1) % waypoints.Length;
                }

                agent.SetDestination(waypoints[index].position);
                break;

            case State.Chase:
                agent.SetDestination(player.position);
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            gameManager.Lose();
    }

    void OnDrawGizmos()
    {
        if (eye == null || player == null) return;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(eye.position, sightRange);
        Gizmos.DrawLine(eye.position, player.position);
    }
}
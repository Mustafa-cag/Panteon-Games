using UnityEngine;
using UnityEngine.AI;

public class Archer : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;
    public float range = 10f;
    public Animator anim;
    public bool areaEnemy = false;

    public GameObject firePoint;

    public float timerShot;

    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        target = GameObject.FindGameObjectWithTag("Target");

        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        agent.SetDestination(target.transform.position);
        Vector2 newpos = transform.position - target.transform.position;

        if(newpos.x > 0)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        else if(newpos.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        float Distance = Vector2.Distance(transform.position, target.transform.position);

        if(areaEnemy == false)
        {
            if(Distance > 1f)
            {
                anim.SetBool("walk", true);
            }
            else if(Distance < 1f)
            {
                anim.SetBool("walk", false);
                anim.SetBool("shot", false);
            }
        }
        else if(areaEnemy == true)
        {
            if (Distance > 1)
            {
                anim.SetBool("shot", false);
                anim.SetBool("walk", true);
            }
            else if (Distance < 1)
            {
                anim.SetBool("walk", false);
                anim.SetBool("shot", true);
            }
        }

        Collider2D hitColliders = Physics2D.OverlapBox(transform.position, new Vector2(range, range), range);
        if(hitColliders.transform.gameObject.CompareTag("Enemy"))
        {
            areaEnemy = true;
            Vector3 targetPosition = new Vector3(hitColliders.transform.position.y, hitColliders.transform.position.y, firePoint.transform.transform.position.x);
            firePoint.transform.LookAt(targetPosition);


            if(anim.GetBool("shot") == true)
            {
                if (timerShot >= 0)
                {
                    timerShot -= Time.deltaTime;
                }
                else
                {
                    ObjectPooling.instance.GetPoolObject();
                    timerShot = 1f;
                }
            }


        }
        else
        {
            areaEnemy = false;
        }
    }




    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector2(range, range));
    }
}

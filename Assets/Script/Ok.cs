using UnityEngine;

public class Ok : MonoBehaviour
{
    public GameObject firePoint;
    private void OnEnable()
    {
        firePoint = GameObject.FindGameObjectWithTag("firePoint");
        transform.position = firePoint.transform.position;
        transform.rotation = firePoint.transform.rotation;
    }
    void Update()
    {
        transform.Translate(0, 0, 10 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }

   
}

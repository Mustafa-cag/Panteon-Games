using UnityEngine;

public class Barrack : MonoBehaviour
{
    public bool areaActive = false;
    public int level = 1;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void white()
    {
        spriteRenderer.color = Color.white;
    }
    public void red()
    {
        spriteRenderer.color = Color.red;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BarrackOne"))
        {
            ShopManager.instance.buildBarrack.GetComponent<Barrack>().red();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BarrackOne"))
        {
            ShopManager.instance.buildBarrack.GetComponent<Barrack>().white();
        }
    }
}

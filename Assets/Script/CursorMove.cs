using UnityEngine;

public class CursorMove : MonoBehaviour
{
    public GameObject[] building;
    public int active = 0;

    public GameObject movePos;

    #region Singleton
    public static CursorMove instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion

    void Update()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        if (ShopManager.instance.buildBarrack != null)
        {
            if (Input.GetMouseButtonDown(0) && ShopManager.instance.buildBarrack.GetComponent<SpriteRenderer>().color == Color.white && GameManager.instance.OnUI == false)
            {
                building[active].transform.parent = null;

                ShopManager.instance.buildBarrack.GetComponent<Barrack>().areaActive = true;

                ShopManager.instance.buttons[active].interactable = false;
                if(ShopManager.instance.buildBarrack.GetComponent<Barrack>().level == 1)
                {
                    LevelControl.instance.soldierPanelImage[0].SetActive(true);
                }

                if(ShopManager.instance.buildBarrack.GetComponent<Barrack>().level == 2)
                {
                    LevelControl.instance.soldierPanelImage[1].SetActive(true);
                }

                if(ShopManager.instance.buildBarrack.GetComponent<Barrack>().level == 3)
                {
                    LevelControl.instance.soldierPanelImage[2].SetActive(true);
                }
                ShopManager.instance.buildBarrack = null;
            }
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            movePos.transform.position = transform.position;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(ShopManager.instance.buildBarrack != null)
            {
                ShopManager.instance.buildBarrack.GetComponent<Barrack>().white();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("BarrackOne"))
        {
            ShopManager.instance.GamePanel.interactable = false;
            if (Input.GetMouseButtonDown(0))
            {
                ShopManager.instance.openButtons();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (ShopManager.instance.buildBarrack != null)
            {
                ShopManager.instance.buildBarrack.GetComponent<Barrack>().red();
            }
        }
        if (collision.gameObject.CompareTag("BarrackOne"))
        {
            ShopManager.instance.GamePanel.interactable = true;
        }
    }
}
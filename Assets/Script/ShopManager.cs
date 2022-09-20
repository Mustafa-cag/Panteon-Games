using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject buildBarrack;
    public GameObject soldierPanel;
    public Button[] buttons;
    public GameObject openButton;
    public Button GamePanel;

    #region Singletob
    public static ShopManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion
    public void openButtons()
    {
        openButton.SetActive(true);
    }

    public void closeButtons()
    {
        openButton.SetActive(false);
    }

    public void LevelOneBarrack()
    {
        if(EnergyCentral.instance.coin >= 100)
        {
            EnergyCentral.instance.coin -= 100;
            EnergyCentral.instance.coinText.text = EnergyCentral.instance.coin.ToString();
            CursorMove.instance.active = 0;
            buildBarrack = CursorMove.instance.building[CursorMove.instance.active].gameObject;
            CursorMove.instance.building[CursorMove.instance.active].gameObject.SetActive(true);

            if (CursorMove.instance.building[1].GetComponent<Barrack>().areaActive == false)
            {
                CursorMove.instance.building[1].SetActive(false);
            }
            else
            {
                CursorMove.instance.building[1].SetActive(true);
            }


            if (CursorMove.instance.building[2].GetComponent<Barrack>().areaActive == false)
            {
                CursorMove.instance.building[2].SetActive(false);
            }
            else
            {
                CursorMove.instance.building[2].SetActive(true);
            }
        }
        
    }

    public void LevelTwoBarrack()
    {
        if(EnergyCentral.instance.coin >= 200)
        {
            EnergyCentral.instance.coin -= 200;
            EnergyCentral.instance.coinText.text = EnergyCentral.instance.coin.ToString();
            CursorMove.instance.active = 1;
            buildBarrack = CursorMove.instance.building[CursorMove.instance.active].gameObject;
            CursorMove.instance.building[CursorMove.instance.active].gameObject.SetActive(true);

            if (CursorMove.instance.building[0].GetComponent<Barrack>().areaActive == false)
            {
                CursorMove.instance.building[0].SetActive(false);
            }
            else
            {
                CursorMove.instance.building[0].SetActive(true);
            }

            if (CursorMove.instance.building[2].GetComponent<Barrack>().areaActive == false)
            {
                CursorMove.instance.building[2].SetActive(false);
            }
            else
            {
                CursorMove.instance.building[2].SetActive(true);
            }
        }
        
    }

    public void LevelThreeBarrack()
    {
        if(EnergyCentral.instance.coin >= 300)
        {
            EnergyCentral.instance.coin -= 300;
            EnergyCentral.instance.coinText.text = EnergyCentral.instance.coin.ToString();
            CursorMove.instance.active = 2;
            buildBarrack = CursorMove.instance.building[CursorMove.instance.active].gameObject;
            CursorMove.instance.building[CursorMove.instance.active].gameObject.SetActive(true);

            if (CursorMove.instance.building[0].GetComponent<Barrack>().areaActive == false)
            {
                CursorMove.instance.building[0].SetActive(false);
            }
            else
            {
                CursorMove.instance.building[0].SetActive(true);
            }


            if (CursorMove.instance.building[1].GetComponent<Barrack>().areaActive == false)
            {
                CursorMove.instance.building[1].SetActive(false);
            }
            else
            {
                CursorMove.instance.building[1].SetActive(true);
            }
        }
        
    }

    public void backToLevel()
    {
        soldierPanel.SetActive(false);
    }

    public void soldierPanelOpen()
    {
        soldierPanel.SetActive(true);
    }
}
using UnityEngine;

public class SoldierManager : MonoBehaviour
{
    public GameObject[] soldierLevel;
    public Transform[] createPos;
   
    public void LevelOneCreateSoldier()
    {
        EnergyCentral.instance.coin -= 5;
        EnergyCentral.instance.coinText.text = EnergyCentral.instance.coin.ToString();
        Instantiate(soldierLevel[0], createPos[0].position, createPos[0].rotation);
    }
    public void LevelTwoCreateSoldier()
    {
        EnergyCentral.instance.coin -= 10;
        EnergyCentral.instance.coinText.text = EnergyCentral.instance.coin.ToString();
        Instantiate(soldierLevel[1], createPos[1].position, createPos[1].rotation);
    }
    public void LevelThreeCreateSoldier()
    {
        EnergyCentral.instance.coin -= 15;
        EnergyCentral.instance.coinText.text = EnergyCentral.instance.coin.ToString();
        Instantiate(soldierLevel[2], createPos[2].position, createPos[2].rotation);
    }

}

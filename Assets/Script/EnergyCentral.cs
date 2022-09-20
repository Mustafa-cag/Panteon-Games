using UnityEngine;
using TMPro;

public class EnergyCentral : MonoBehaviour
{
    public Sprite image;
    public int coin;
    public TextMeshProUGUI coinText;
    public float coinTimer = 2f;

    public static EnergyCentral instance = null;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    private void Start()
    {
        coinText.text = coin.ToString();
    }

    private void Update()
    {
        if(coinTimer > 0)
        {
            coinTimer -= Time.deltaTime;
        }
        else
        {
            coinTimer = 2f;
            coin += 5;
            coinText.text = coin.ToString();
        }
    }

    public void OnMouseEnter()
    {
        var tempColor = GameManager.instance.Image.color;
        tempColor.a = 1f;
        GameManager.instance.Image.color = tempColor;
        var tempColorAlpha = GameManager.instance.ImageSoldier.color;
        tempColorAlpha.a = 0f;
        GameManager.instance.ImageSoldier.color = tempColorAlpha;
        GameManager.instance.textingBuilding.text = "By producing gold from the power plant, you can get military units and build buildings in the places you have conquered.";
        GameManager.instance.buildLabel.text = "Energy Central";
        GameManager.instance.Image.sprite = image;
    }

    private void OnMouseExit()
    {
        var tempColor = GameManager.instance.Image.color;
        tempColor.a = 0f;
        GameManager.instance.Image.color = tempColor;
        var tempColorAlpha = GameManager.instance.ImageSoldier.color;
        tempColorAlpha.a = 0f;
        GameManager.instance.ImageSoldier.color = tempColorAlpha;
        GameManager.instance.textingBuilding.text = "...";
        GameManager.instance.buildLabel.text = "...";
    }
}

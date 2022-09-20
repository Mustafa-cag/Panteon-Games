using UnityEngine;

public class SoldierHome : MonoBehaviour
{

    public Sprite image;
    public Sprite imageSoldier;

    public void OnMouseEnter()
    {
        var tempColor = GameManager.instance.Image.color;
        tempColor.a = 1f;
        GameManager.instance.Image.color = tempColor;
        var tempColorAlpha = GameManager.instance.ImageSoldier.color;
        tempColorAlpha.a = 1f;
        GameManager.instance.ImageSoldier.color = tempColorAlpha;
        GameManager.instance.textingBuilding.text = "You can craft your military units from this building! The barracks are your center of attack and defense.";
        GameManager.instance.buildLabel.text = "Barrack";
        GameManager.instance.Image.sprite = image;
        GameManager.instance.ImageSoldier.sprite = imageSoldier;
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

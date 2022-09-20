using UnityEngine;

public class ProductionPanelOn : MonoBehaviour
{
    public void OnMouseEnter()
    {
        GameManager.instance.OnUI = true;
    }

    public void OnMouseExit()
    {
        GameManager.instance.OnUI = false;
    }
}

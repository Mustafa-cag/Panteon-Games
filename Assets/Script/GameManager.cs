using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject secilen;
    public bool OnUI = false;
    public bool deneme = false;

    [Header("Information Panel")]
    public Image Image;
    public Image ImageSoldier;
    public TextMeshProUGUI textingBuilding;
    public TextMeshProUGUI buildLabel;

    #region Singleton
    public static GameManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion

    private void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = -1;
        transform.position = pos;
    }
}

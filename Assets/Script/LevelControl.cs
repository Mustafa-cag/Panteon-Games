using UnityEngine;

public class LevelControl : MonoBehaviour
{
    #region Singleton
    public static LevelControl instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion

    public GameObject[] soldierPanelImage;
}

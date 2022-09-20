using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    private Vector3 dragOrigin;

    [SerializeField]
    private float minCamSize, maxCamSize;

    void Update()
    {
        PanCamera();

        if(GameManager.instance.OnUI == false)
        {
            if (Input.mouseScrollDelta.y > 0)
            {
                cam.orthographicSize -= 0.3f;
            }
            if (Input.mouseScrollDelta.y < 0)
            {
                cam.orthographicSize += 0.3f;
            }
        }
        

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minCamSize, maxCamSize);

        Vector3 ClampPosX = transform.position;
        ClampPosX.x = Mathf.Clamp(ClampPosX.x, -9f, 9f);
        transform.position = ClampPosX;

        Vector3 ClampPosY = transform.position;
        ClampPosY.y = Mathf.Clamp(ClampPosY.y, -12f, 12f);
        transform.position = ClampPosY;
    }

    private void PanCamera()
    {
        if(Input.GetMouseButtonDown(1))
        {
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButton(1))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
            cam.transform.position += difference;
        }
    }
}

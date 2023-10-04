using UnityEngine;

public class DragAndRotate : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 lastMousePos;
    public float rotationSpeed = 2.0f;

    void Update()
    {
        HandleRotation();
        DebugRay();
    }

    void DebugRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);
    }

    private void HandleRotation()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                dragging = true;
                lastMousePos = Input.mousePosition;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }

        if (dragging)
        {
            Vector3 deltaMousePos = Input.mousePosition - lastMousePos;

            float rotationX = deltaMousePos.y * rotationSpeed;
            float rotationY = -deltaMousePos.x * rotationSpeed;

            transform.rotation *= Quaternion.Euler(rotationX, rotationY, 0);
            lastMousePos = Input.mousePosition;
        }
    }

}

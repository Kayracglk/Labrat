using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] float defDistanceRay;
    [SerializeField] GameObject healthManager;
    [SerializeField] Transform laserFirePoint, transform;
    [SerializeField] LineRenderer lineRenderer;
    HealthBar healthBar;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        healthBar = healthManager.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootLaser();
        if(hit.collider.CompareTag("Player"))
        {
            healthBar.currentHealth = healthBar.currentHealth-5;
        }
    }
    void ShootLaser()
    {
        if (Physics2D.Raycast(transform.position,-transform.up))
        {
            hit = Physics2D.Raycast(laserFirePoint.position,-transform.up);
            Draw2DRay(laserFirePoint.position,hit.point);
        }
        else
        {
            Draw2DRay(laserFirePoint.position, -laserFirePoint.transform.up*defDistanceRay);
        }
    }
    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        lineRenderer.SetPosition(0,startPos);
        lineRenderer.SetPosition(1, endPos);

    }
}

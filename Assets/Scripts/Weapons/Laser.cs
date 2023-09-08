using System.Collections;
using UnityEngine;

namespace DeeppTest.Weapons
{
    public class Laser : Weapon
    {
        [SerializeField]
        private LineRenderer lineRenderer;

        private bool isCoroutineRunning = false;

        public override void Fire()
        {
            base.Fire();
            if (ammo > 0)
            {
                if (!isCoroutineRunning)
                {
                    ammo--;
                    Vector3 startPoint = Vector3.zero;
                    Vector3 endPoint = startPoint + Vector3.forward * range;

                    RaycastHit hit;
                    if (Physics.Raycast(
                        lineRenderer.transform.position + lineRenderer.transform.TransformDirection(Vector3.forward), 
                        lineRenderer.transform.TransformDirection(Vector3.forward), 
                        out hit, 
                        range
                        ))
                    {
                        endPoint = lineRenderer.transform.InverseTransformPoint(hit.point);
                        IDamagable damagable = hit.collider.GetComponentInParent<IDamagable>();
                        if (damagable != null)
                        {
                            damagable.GetDamage(damage);
                        }
                    }

                    lineRenderer.SetPosition(0, startPoint);
                    lineRenderer.SetPosition(1, endPoint);

                    lineRenderer.enabled = true;

                    StartCoroutine(DisableLineRenderer());
                }
            }
        }

        private IEnumerator DisableLineRenderer()
        {
            isCoroutineRunning = true;

            yield return new WaitForSeconds(cooldown);

            lineRenderer.enabled = false;
            isCoroutineRunning = false;
        }
    }
}

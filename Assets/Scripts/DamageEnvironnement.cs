using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnvironnement : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        RubyController controller = collision.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health > 0)
            {
                controller.ChangeHealth(-1);
            }
        }
    }
}

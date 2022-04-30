using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject Player;

    /* private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.name == "Third Person Player")
          {
              collision.gameObject.transform.SetParent(transform);
          }
      }

      private void OnCollisionExit(Collision collision)
      {
          if (collision.gameObject.name == "Third Person Player")
          {
              collision.gameObject.transform.SetParent(null);
          }
      }*/

     private void OnTriggerEnter(Collider other)
     {

         if (other.gameObject.tag == "Player")
         {
            Debug.Log("PrzykleilemSieDoPlatformy");
            Player.transform.parent = transform;

         }
     }

     private void OnTriggerExit(Collider other)
     {
         if (other.gameObject.tag == "Player")
         {
            Player.transform.parent = null;

        }
     } 
      
}

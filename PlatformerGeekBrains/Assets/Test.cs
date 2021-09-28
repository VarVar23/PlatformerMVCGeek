using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private ContactPoint2D[] contactPoint2D = new ContactPoint2D[10];
    private void Update()
    {
        int a = GetComponent<Collider2D>().GetContacts(contactPoint2D);
        for (int i = 0; i < a; i++)
        {
            Debug.Log(i + " " + contactPoint2D[i].normal);
        }
    }

    //private ContactPoint2D[] _contacts = new ContactPoint2D[10];
    //private int _contactsCount;
    //private Collider2D _collider2D;


    //public void Start()
    //{
    //    _collider2D = GetComponent<Collider2D>() ;
    //}

    //public void Update()
    //{
    //    _contactsCount = _collider2D.GetContacts(_contacts);
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Debug.Log(i + " " + _contacts[i].normal);
    //    }
    //}
}
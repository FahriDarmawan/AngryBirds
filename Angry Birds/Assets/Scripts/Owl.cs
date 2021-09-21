using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owl : Bird
{
    private bool explode = false;

    [SerializeField] private GameObject _explosion;

    public void Boom()
    {
        if(State == BirdState.Thrown && !explode)
        {
            GameObject obj;
            obj = Instantiate(_explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            obj.SetActive(true);
            explode = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Boom();
    }
}

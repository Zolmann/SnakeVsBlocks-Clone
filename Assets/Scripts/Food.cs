using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public Transform Player;
    private int _value;
    private AudioSource _sound; 
    void Awake()
    {
        _sound = GetComponent<AudioSource>();
        _value = Random.Range(1, 6);
    }
    private void OnTriggerEnter(Collider other)
    {
        _sound.Play();
        Player.localScale = new Vector3(Player.localScale.x, Player.localScale.y, Player.localScale.z + _value);
        
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstacle : MonoBehaviour
{
    private int _basepower;
    public Player Player;
    private readonly float _colorMultiplier = 0.02f;
    public TMP_Text _text;
    private ParticleSystem _particleSystem;
    void Awake()
    {
        _basepower = Random.Range(1, 26);
        gameObject.GetComponent<Renderer>().material.SetFloat("Power", _basepower * _colorMultiplier);
        _text.text = _basepower.ToString();
        _particleSystem = GetComponent<ParticleSystem>();
    }
    private void OnCollisionStay(Collision collision)
    {
        _particleSystem.Play();
        int _power = _basepower;
        while (_power  > 0)
        {
            Debug.Log($"Hp left:{_power}");
            _power--;
            Player.HP--;
        }
        if (_basepower < 10) Destroy(gameObject, 0.1f * _basepower);
        else Destroy(gameObject, (0.05f * _basepower));
    }
}

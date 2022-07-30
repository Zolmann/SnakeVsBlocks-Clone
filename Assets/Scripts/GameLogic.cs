using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public Controls Controls;
    private AudioSource _maintheme;
    public RestartUI RestartUI;
    public FinishUI FinishUI;
    public MainScreen MainScreen;
   public enum Status
    {
        Play,
        Lose,
        Win
    }
    public Status CurrentStatus { get; private set; }
    private void Start()
    {
        _maintheme = GetComponent<AudioSource>();
        _maintheme.Play();
    }
    public void OnDeath()
    {
        if (CurrentStatus != Status.Play) return;

        _maintheme.Stop();
        CurrentStatus = Status.Lose;
        Controls.Player.gameObject.SetActive(false);
        RestartUI.gameObject.SetActive(true);
        MainScreen.gameObject.SetActive(false);
    }
    public void OnWin()
    {
        if (CurrentStatus != Status.Play) return;

        _maintheme.Stop();
        CurrentStatus = Status.Win;
        Controls.Player.gameObject.SetActive(false);
        FinishUI.gameObject.SetActive(true);
        MainScreen.gameObject.SetActive(false);
    }
}

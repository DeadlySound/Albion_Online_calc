using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class God: MonoBehaviour
{
    public string Name { get; set; }
    // TODO change the player variable to Player object
    [CanBeNull] public string _playerWithHighestBid { get; }
    public int CurrentBid { get; set; }
    public event Action Recruit;
    public event Action Build;
    public event Action SpecialAction;

    private void OnRecruit()
    {
        Recruit?.Invoke();
    }

    private void OnBuild()
    {
        Build?.Invoke();
    }

    private void OnSpecialAction()
    {
        SpecialAction?.Invoke();
    }
}

using System;
using UnityEngine;

public sealed class MainMenuManager : MonoBehaviour
{
    public void LaunchSkillz()
    {
        SkillzCrossPlatform.LaunchSkillz(new GameController());
    }

    private void Start()
    {
        LaunchSkillz();
    }
}
using SkillzSDK;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : SkillzMatchDelegate
{
    private const string GAME_SCENE_NAME = "Game Scene";
    private const string MENU_SCENE_NAME = "Menu Scene";
    
    public void OnMatchWillBegin(Match matchInfo)
    {
        SceneManager.LoadScene(GAME_SCENE_NAME);    
    }

    public void OnSkillzWillExit()
    {
        SceneManager.LoadScene(MENU_SCENE_NAME);
    }
}
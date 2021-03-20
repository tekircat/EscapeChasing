using UnityEngine;

public class CompleteLevel : MonoBehaviour {

	public string menuSceneName = "MainMenu";

	public string nextLevel2 = "Level02";
	public string nextLevel3 = "Level03";
	public string nextLevel4 = "Level04";
	public string nextLevel5 = "Level05";
	public string nextLevel6 = "Level06";
	public string nextLevel7 = "Level07";
	public string nextLevel8 = "Level08";
	public string nextLevel9 = "Level09";
	public string nextLevel10 = "Level10";

	public int levelToUnlock2 = 2;
	public int levelToUnlock3 = 3;
	public int levelToUnlock4 = 4;
	public int levelToUnlock5 = 5;
	public int levelToUnlock6 = 6;
	public int levelToUnlock7 = 7;
	public int levelToUnlock8 = 8;
	public int levelToUnlock9 = 9;
	public int levelToUnlock10 = 10;

	public SceneFader sceneFader;

	public void Continue2 ()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock2);
		sceneFader.FadeTo(nextLevel2);
	}

	public void Continue3()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock3);
		sceneFader.FadeTo(nextLevel3);
	}

	public void Continue4()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock4);
		sceneFader.FadeTo(nextLevel4);
	}

	public void Continue5()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock5);
		sceneFader.FadeTo(nextLevel5);
	}

	public void Continue6()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock6);
		sceneFader.FadeTo(nextLevel6);
	}

	public void Continue7()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock7);
		sceneFader.FadeTo(nextLevel7);
	}

	public void Continue8()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock8);
		sceneFader.FadeTo(nextLevel8);
	}

	public void Continue9()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock9);
		sceneFader.FadeTo(nextLevel9);
	}

	public void Continue10()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock10);
		sceneFader.FadeTo(nextLevel10);
	}

	public void Menu ()
	{
		sceneFader.FadeTo(menuSceneName);
	}

}

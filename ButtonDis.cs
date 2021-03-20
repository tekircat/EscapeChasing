
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDis : MonoBehaviour
{

	public static float elmas;	
	public GameObject buyButton4;
	public GameObject buyButton5;
	
	void Start()
	{
		buyButton4.gameObject.SetActive(PlayerPrefs.GetInt("buyButton4") != 1);
		buyButton5.gameObject.SetActive(PlayerPrefs.GetInt("buyButton5") != 1);
	}

	public void del()
	{
		PlayerPrefs.DeleteAll();
	}

	public void bin()
	{
		elmas = elmas + 100000;
		PlayerPrefs.SetFloat("elmas", elmas);
	}

	void Update()
	{  
		elmas = PlayerPrefs.GetFloat("elmas");
	}

	public void Butt4()
	{
		if (elmas >= 10)
		{
			buyButton4.gameObject.SetActive(false);
			elmas = elmas - 10;
			PlayerPrefs.SetInt("buyButton4", 1);
		}
		else
		{
			buyButton4.gameObject.SetActive(true);
		}
		PlayerPrefs.SetFloat("elmas", elmas);
	}

	public void Butt5()
	{
		if (elmas >= 10)
		{
			buyButton5.gameObject.SetActive(false);
			elmas = elmas - 10;
			PlayerPrefs.SetInt("buyButton5", 1);
		}
		else
		{
			buyButton5.gameObject.SetActive(true);
		}
		PlayerPrefs.SetFloat("elmas", elmas);
	}
}



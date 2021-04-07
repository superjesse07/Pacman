using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectDisplay : MonoBehaviour
{

	public Effect effect;
	public Image bar;
	public Text text;
	
	void Start ()
	{
		text.text = effect.name;
	}
	
	void Update ()
	{
		bar.fillAmount = effect.timer / effect.duration;
		if(bar.fillAmount <= 0) Destroy(gameObject);
	}
}

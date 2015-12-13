using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System.Reflection;
using System;

public class IndexView : MonoBehaviour {

	void Start () {
		GameObject sceneTitle = GameObject.Find ("SceneTitle");
		var titleText = sceneTitle.GetComponentInChildren<Text>();
		titleText.text = "Index";

		PlayerPrefs.SetInt( "previousLevel", Application.loadedLevel );

		GameObject scrollView = GameObject.Find ("Scroll View");
		ScrollViewController scrollViewController = scrollView.GetComponent<ScrollViewController> ();

		scrollViewController.SetListItem ("Auth", delegate() {
			Application.LoadLevel("Auth");
		});
		scrollViewController.SetListItem ("Bank", delegate() {
			Application.LoadLevel("Bank");
		});
	}

	void Update () {
	
	}
}

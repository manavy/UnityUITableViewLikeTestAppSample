using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class ScrollViewController : MonoBehaviour {
	
	public RectTransform parent;

	public GameObject listItemPrefab;

	public void SetListItem(string name, UnityAction action){
		GameObject listItemButton = GameObject.Instantiate (listItemPrefab) as GameObject;
		listItemButton.transform.SetParent (parent, false);

		var text = listItemButton.GetComponentInChildren<Text>();
		text.text = name;

		var button = listItemButton.GetComponentInChildren<Button>();
		button.onClick.AddListener (action);
	}

	// Use this for initialization
	void Start () {
	}
}

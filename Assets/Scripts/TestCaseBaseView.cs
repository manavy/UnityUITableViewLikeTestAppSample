using UnityEngine;
using System.Collections;
using System.Reflection;
using System;

public class TestCaseBaseView : MonoBehaviour {

	protected void extractTestMethods(){
		GameObject scrollView = GameObject.Find ("Scroll View");
		ScrollViewController scrollViewController = scrollView.GetComponent<ScrollViewController> ();

		// adding methods start with "Test" to the list
		MethodInfo[] methods = GetType ().GetMethods (BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
		foreach (MethodInfo method in methods) {
			if (method.Name.StartsWith ("Test")) {
				MethodInfo m = method;
				scrollViewController.SetListItem (method.Name, delegate() {
					m.Invoke (null, null);
				});
			}
		}
	}

	public void OnBackButtonClicked(){
		int previousLevel = PlayerPrefs.GetInt( "previousLevel" );
		Application.LoadLevel( previousLevel );
	}
}

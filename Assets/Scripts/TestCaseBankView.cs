using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System.Reflection;
using System;

public class TestCaseBankView : TestCaseBaseView {

	void Start () {
		GameObject sceneTitle = GameObject.Find ("SceneTitle");
		var titleText = sceneTitle.GetComponentInChildren<Text>();
		titleText.text = "Bank";

		extractTestMethods ();
	}

	void Update () {
	
	}

	public static void TestMethod1(){
		Debug.Log ("TestMethod1 invoked");
	}

	public static void TestMethod2(){
		Debug.Log ("TestMethod2 invoked");
	}

	public static void TestMethod3(){
		Debug.Log ("TestMethod3 invoked");
	}

	public static void TestMethod4(){
		Debug.Log ("TestMethod4 invoked");
	}

}

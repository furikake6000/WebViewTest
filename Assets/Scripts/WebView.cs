using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebView : MonoBehaviour {

	WebViewObject wb;

	// Use this for initialization
	void Start () {
		wb = gameObject.GetComponent<WebViewObject>();

		wb.Init((msg) => {
            Debug.Log(msg);
        });
        wb.LoadURL("https://shinchoku.net");
        // 中央に配置
        wb.SetMargins(0, 0, 0, 0);
        wb.SetVisibility(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

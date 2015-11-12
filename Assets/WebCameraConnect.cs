using UnityEngine;
using System.Collections;

public class WebCameraConnect : MonoBehaviour {
    public int Width = 1920;  // 幅.
    public int Height = 1080; // 高さ.
    public int FPS = 30;      // フレームレート.

	// Use this for initialization
	void Start () {
        WebCamDevice[] devices = WebCamTexture.devices;

        // 有効なデバイスのリストを取得
        for(var i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }

        // 最初のカメラを取得して再生
        if(devices.Length > 0)
        {
            WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = webcamTexture;
            // GetComponent<Renderer>().material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }

        // エラー処理
        if(devices.Length == 0)
        {
            Debug.LogError("Webカメラを検出できませんでした．= ");
            return;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

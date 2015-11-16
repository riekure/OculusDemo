using UnityEngine;
using UnityEngine.VR;
using System.Collections;

public class VRDeviceDemo : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        // Oculus Riftが接続されている場合は"oculus"，接続されていない場合は"none"
        Debug.Log(VRDevice.family);
        // VRデバイスが接続の有無を取得，bool型
        Debug.Log(VRDevice.isPresent);
        // ロードされたVRデバイスの名前を取得(Oculus Rift DK2)，接続されていない場合は空
        Debug.Log(VRDevice.model);
	}
	
	// Update is called once per frame
	void Update () {
        /*
        Vector3 pos = UnityEngine.VR.InputTracking.GetLocalPosition(UnityEngine.VR.VRNode.Head);
        Debug.Log(pos.x);
        Debug.Log(pos.y);
        Debug.Log(pos.z);
        */
	}
}

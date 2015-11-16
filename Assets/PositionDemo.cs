using UnityEngine;
using VR = UnityEngine.VR;
using UnityEngine.UI;
using System.Collections;

public class PositionDemo : MonoBehaviour {
  
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Vector3 left = VR.InputTracking.GetLocalPosition(VR.VRNode.LeftEye);
        Vector3 right = VR.InputTracking.GetLocalPosition(VR.VRNode.RightEye);
        Vector3 center = VR.InputTracking.GetLocalPosition(VR.VRNode.CenterEye);
        Vector3 head = VR.InputTracking.GetLocalPosition(VR.VRNode.Head);

        this.GetComponent<Text>().text =
            "Right:　"
            + Mathf.Round(right.x * 100) / 100 + ", "
            + Mathf.Round(right.y * 100) / 100 + ", "
            + Mathf.Round(right.z * 100) / 100 +
            "\nLeft: 　"
            + Mathf.Round(left.x * 100) / 100 + ", "
            + Mathf.Round(left.y * 100) / 100 + ", "
            + Mathf.Round(left.z * 100) / 100 +
            "\nCenter:"
            + Mathf.Round(center.x * 100) / 100 + ", "
            + Mathf.Round(center.y * 100) / 100 + ", "
            + Mathf.Round(center.z * 100) / 100 +
            "\nHead:　"
            + Mathf.Round(head.x * 100) / 100 + ", "
            + Mathf.Round(head.y * 100) / 100 + ", "
            + Mathf.Round(head.z * 100) / 100;
 	}
}

using UnityEngine;
using VR = UnityEngine.VR;
using UnityEngine.UI;
using System.Collections;

public class RotationDemo : MonoBehaviour {
  
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Quaternion left = VR.InputTracking.GetLocalRotation(VR.VRNode.LeftEye);
        Quaternion right = VR.InputTracking.GetLocalRotation(VR.VRNode.RightEye);
        Quaternion center = VR.InputTracking.GetLocalRotation(VR.VRNode.CenterEye);
        Quaternion head = VR.InputTracking.GetLocalRotation(VR.VRNode.Head);

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

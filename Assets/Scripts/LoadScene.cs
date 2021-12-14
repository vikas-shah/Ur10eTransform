using System.IO;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class LoadScene : MonoBehaviour
    {
        private void Awake()
        {
            GameObject emptyObject = new GameObject("test");
            emptyObject.transform.position = Vector3.zero;
            emptyObject.transform.rotation = Quaternion.identity;
            
            GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);
            plane.transform.SetParent(emptyObject.transform);
            
            GameObject obj = (GameObject) Resources.Load("Prefabs/ur10e");
            GameObject arm = Instantiate(obj, emptyObject.transform) as GameObject;
            arm.name = "ur10e";
        }
    }
}
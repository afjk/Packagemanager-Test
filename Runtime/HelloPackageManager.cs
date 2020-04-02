using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace com.afjk.test
{
    public class HelloPackageManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("HelloPackageManager !");
            // form GitHub
            Debug.Log(Path.GetFullPath("Packages/com.afjk.test-package"));
            // Unity Project Path
            Debug.Log(Path.GetFullPath("Assets/.."));
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
    
}

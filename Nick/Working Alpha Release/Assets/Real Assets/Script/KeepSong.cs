using UnityEngine;
using System.Collections;

public class KeepSong : MonoBehaviour {
 
    private static KeepSong instance = null;
    public static KeepSong Instance {
        get { return instance; }
    }
    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
 
    // any other methods you need
}
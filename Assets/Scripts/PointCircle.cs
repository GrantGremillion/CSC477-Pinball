using UnityEngine;

public class PointCircle : MonoBehaviour {
    // set in inspector
    
    private readonly Color inactiveColor = new Color(45 / 255.0f, 97 / 255.0f, 108 / 255.0f);
    private readonly Color activeColor = new Color(121 / 255.0f, 255 / 255.0f, 249 / 255.0f);
    public GamePlay gameScript;
     public GameObject soundManager;

    public void Hit() {
        gameScript.score += 2000;
        soundManager.GetComponent<SoundEffects>().playSoundCircle();
    }
}

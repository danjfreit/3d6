using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Dice", menuName = "Dice", order = 0)]
public class Dice : ScriptableObject {
 
    private const string assetpath = "Dice";
 
    private static Dice _instance;
    private static Dice instance {
        get { return _instance ?? (_instance = Resources.Load<Dice>(assetpath)); }
    }

    public GameObject die;
    private static GameObject Die { get {return instance.die;} }

    [MenuItem("PlayModeDebug/Roll")]
    public static GameObject Roll() {
        return GameObject.Instantiate(Die, new Vector3(0, 0, 5), Quaternion.identity);
    }
}
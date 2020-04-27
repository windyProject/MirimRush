using UnityEngine;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;
using System.Collections.Generic;
using UnityEngine.UI;
    class User {
        public string name;
        public string score;

        public User(){}
        public User(string name, string score) {
            this.name = name;
            this.score = score;
        }
    public Dictionary<string, object> ToDictionary()
    {
        Dictionary<string, object> result = new Dictionary<string, object>();
        result["name"] = name;
        result["score"] = score;

        return result;
    }
}
public class FirebaseTest : MonoBehaviour
{
    // Start is called before the first frame update
    private static FirebaseTest Instance;
    private DatabaseReference reference;

    public InputField namee;
    public InputField score;
    public GameObject btn;

    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://mirimrush-test.firebaseio.com/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;

    }

    public void OnCilk() {
        User us = new User(namee.text, score.text);
        string json = JsonUtility.ToJson(us);
        reference.Child("users").Child("us").SetRawJsonValueAsync(json);
    }




    // Update is called once per frame
    void Update()
    {
        FirebaseDatabase.DefaultInstance.GetReference("users").GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                Debug.Log("failed");

            }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                //Debug.Log(snapshot.Child("users").Child("user").Child("name"));
                Debug.Log(
            }
        });

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameController : MonoBehaviour {

    public int num;

    public GameObject Player;

    public static bool isPause;
    public static bool bagIsOpen;
    public static bool gameOver;

    // Weopen
    public static bool GunDone;
    public static bool BowDone;
    public static bool PanDone;
    public static bool IronDone;
    public static bool LoveDone;
    public static bool LaserDone;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F4))
        {
            GunDone = true;
            BowDone = true;
            PanDone = true;
            IronDone = true;
            LoveDone = true;
            LaserDone = true;
        }

        if (gameOver == true)
        {
            ChangeRoom.GoToGameOver();
        }
    }

    public void SaveGame()
    {
        Save save = CreateSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        Debug.Log("Game Saved");
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.num = num;
        save.PlayerPositionX = Player.transform.position.x;
        save.PlayerPositionZ = Player.transform.position.z;
        save.PlayerRotationY = Player.transform.rotation.y;

        return save;
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();
            Player.transform.position = new Vector3(save.PlayerPositionX,0,save.PlayerPositionZ);
            Player.transform.rotation = new Quaternion(0, save.PlayerRotationY, 0, 0);
            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }    
}

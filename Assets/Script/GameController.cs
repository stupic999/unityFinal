using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameController : MonoBehaviour {

    public static float LoveFireCD;
    public static bool LoadLoveCD;

    AudioSource audioSource;

    public AudioClip BossDie;
    public AudioClip GameOverSound;

    public GameObject GameOverUI;

    public static bool Win;

    public GameObject WinUI;

    public GameObject WordB;
    public GameObject WordR;

    public static int monstersDie;

    public GameObject mainRoomController;

    public MonsterChase mT;
    public MonsterChase m0;
    public MonsterChase m1;
    public MonsterChase m2;
    public MonsterChase m3;
    public MonsterChase m4;
    public MonsterChase m5;
    public MonsterChase m6;
    public MonsterChase m7;
    public MonsterChase m8;
    public MonsterChase m9;
    public MonsterChase m10;
    public MonsterChase m11;
    public MonsterChase m12;
    public MonsterChase m13;
    public MonsterChase m14;
    public MonsterChase m15;
    public MonsterChase m16;
    public MonsterChase m17;

    public PlayerController playerController;

    public static Vector3 lastCheckPoint;

    public static bool MonsterTFound;
    public GameObject MonsterT;
    public static int MonsterTHp = 30;
    public MonsterWordController monsterT;

    public static bool Monster0Found;
    public GameObject Monster0;
    public static int Monster0Hp = 50;
    public MonsterWordController monster0;

    public static bool Monster1Found;
    public GameObject Monster1;
    public static int Monster1Hp = 80;
    public MonsterController monster1;

    public static bool Monster2Found;
    public GameObject Monster2;
    public static int Monster2Hp = 80;
    public MonsterController monster2;

    public static bool Monster3Found;
    public GameObject Monster3;
    public static int Monster3Hp = 80;
    public MonsterController monster3;

    public static bool Monster4Found;
    public GameObject Monster4;
    public static int Monster4Hp = 80;
    public MonsterController monster4;

    public static bool Monster5Found;
    public GameObject Monster5;
    public static int Monster5Hp = 80;
    public MonsterController monster5;

    public static bool Monster6Found;
    public GameObject Monster6;
    public static int Monster6Hp = 80;
    public MonsterController monster6;

    public static bool Monster7Found;
    public GameObject Monster7;
    public static int Monster7Hp = 80;
    public MonsterController monster7;

    public static bool Monster8Found;
    public GameObject Monster8;
    public static int Monster8Hp = 120;
    public MonsterController monster8;

    public static bool Monster9Found;
    public GameObject Monster9;
    public static int Monster9Hp = 120;
    public MonsterController monster9;

    public static bool Monster10Found;
    public GameObject Monster10;
    public static int Monster10Hp = 120;
    public MonsterController monster10;

    public static bool Monster11Found;
    public GameObject Monster11;
    public static int Monster11Hp = 120;
    public MonsterController monster11;

    public static bool Monster12Found;
    public GameObject Monster12;
    public static int Monster12Hp=120;
    public MonsterController monster12;

    public static bool Monster13Found;
    public GameObject Monster13;
    public static int Monster13Hp = 120;
    public MonsterController monster13;

    public static bool Monster14Found;
    public GameObject Monster14;
    public static int Monster14Hp = 50;
    public MonsterController monster14;

    public static bool Monster15Found;
    public GameObject Monster15;
    public static int Monster15Hp = 50;
    public MonsterController monster15;

    public static bool Monster16Found;
    public GameObject Monster16;
    public static int Monster16Hp = 50;
    public MonsterController monster16;

    public static bool Monster17Found;
    public GameObject Monster17;
    public static int Monster17Hp = 50;
    public MonsterController monster17;

    // 读取场景不被破坏的物件
    public Dialogue dialogue;
    public GameObject Controller;
    public GameObject Player;
    public Camera MainCamare;
    public GameObject UI;
    public GameObject MonsterRoot;
    public GameObject MonsterTSearch;

    public GameObject live1;
    public GameObject live2;
    public GameObject live3;

    public static bool firstRoomStarted;
    public static bool mainRoomStarted;

    public static bool FirstRoomPortalDone;

    public static bool isMenu;
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

    public static bool UDone;
    public static bool BDone;
    public static bool WDone;
    public static bool PDone;
    public static bool IDone;
    public static bool RDone;
    public static bool VDone;
    public static bool SDone;

    public static bool BagDone;

    public static int scene;

    public static int dieTime;

    public static int playerHp=100;
    public static bool isLoadHp;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {

        if (scene == 1)
        {
            mainRoomController.SetActive(true);
        }
        else
        {
            mainRoomController.SetActive(false);
        }

        if (dieTime == 0)
        {
            live1.SetActive(true);
            live2.SetActive(true);
            live3.SetActive(true);
        }
        else if (dieTime == 1)
        {
            live1.SetActive(true);
            live2.SetActive(true);
            live3.SetActive(false);
        }
        else if (dieTime == 2)
        {
            live1.SetActive(true);
            live2.SetActive(false);
            live3.SetActive(false);
        }
        else
        {
            live1.SetActive(false);
            live2.SetActive(false);
            live3.SetActive(false);
        }

        // 作弊
        if (Input.GetKey(KeyCode.F4))
        {
            GunDone = true;
            BowDone = true;
            PanDone = true;
            IronDone = true;
            LoveDone = true;
            LaserDone = true;
        }

        if (Input.GetKey(KeyCode.F5))
        {
            ChangeRoom.GoToMainRoom();
            DontDestroyOnLoad(Controller);
            DontDestroyOnLoad(Player);
            DontDestroyOnLoad(MainCamare);
            MainCamare.orthographicSize = 5;
            DontDestroyOnLoad(UI);
            DontDestroyOnLoad(MonsterRoot);
            DontDestroyOnLoad(MonsterTSearch);
            Player.transform.position = new Vector3(-48, 0, -23);
            lastCheckPoint = new Vector3(-48, 0, -23);
            MonsterTSearch.SetActive(false);
            MonsterRoot.SetActive(true);
            scene = 1;
        }

        if (Input.GetKey(KeyCode.F6))
        {
            ChangeRoom.GoToBossRoom();
            DontDestroyOnLoad(Controller);
            DontDestroyOnLoad(Player);
            DontDestroyOnLoad(MainCamare);
            MainCamare.orthographicSize = 5;
            DontDestroyOnLoad(UI);
            DontDestroyOnLoad(MonsterRoot);
            Player.transform.position = new Vector3(-13, 0, -13);
            lastCheckPoint = new Vector3(-13, 0, -13);
            DontDestroyOnLoad(MonsterTSearch);
            scene = 2;
            MonsterRoot.SetActive(false);
        }

        if (gameOver == true)
        {
            GameOverUI.SetActive(true);
            isPause = true;
            gameOver = false;
            audioSource.PlayOneShot(GameOverSound);
        }

        if (Win == true)
        {
            audioSource.PlayOneShot(BossDie);
            WinUI.SetActive(true);
            isPause = true;
            Win = false;
        }

        if (isPause == true || bagIsOpen == true || isMenu==true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void SaveGame()
    {
        audioController.Btn = true;
        if (scene == 2)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else
        {
            Save save = CreateSaveGameObject();

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
            bf.Serialize(file, save);
            file.Close();
        }
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.LoveFireCD = LoveFireCD;

        save.PlayerPositionX = Player.transform.position.x;
        save.PlayerPositionZ = Player.transform.position.z;
        save.PlayerRotationY = Player.transform.rotation.y;

        save.GunDone = GunDone;
        save.BowDone = BowDone;
        save.PanDone = PanDone;
        save.IronDone = IronDone;
        save.LoveDone = LoveDone;
        save.LaserDone = LaserDone;

        save.UDone = UDone;
        save.BDone = BDone;
        save.WDone = WDone;
        save.PDone = PDone;
        save.IDone = IDone;
        save.RDone = RDone;
        save.VDone = VDone;
        save.SDone = SDone;

        save.BagDone = BagDone;

        save.gunPhare = BagPage.gunPhare;
        save.bowPhare = BagPage.bowPhare;
        save.panPhare = BagPage.panPhare;
        save.ironPhare = BagPage.ironPhare;
        save.lovePhare = BagPage.lovePhare;
        save.laserPhare = BagPage.laserPhare;

        save.useWhatWeopen = WeopenController.useWhatWeopen;

        save.scene = scene;

        save.dieTime = dieTime;

        save.firstRoomStarted = firstRoomStarted;
        save.mainRoomStarted = mainRoomStarted;

        save.FirstRoomPortalDone = FirstRoomPortalDone;

        save.playerHp = playerHp;

        save.MonsterTHp = MonsterTHp;
        save.MonsterTPositionX = MonsterT.transform.position.x;
        save.MonsterTPositionZ = MonsterT.transform.position.z;
        save.MonsterTRotationY = MonsterT.transform.rotation.y;
        save.MonsterTAlive = monsterT.GetComponent<MonsterWordController>().Alive;
        save.MonsterTFound = MonsterTFound;

        save.Monster0Hp = Monster0Hp;
        save.Monster0PositionX = Monster0.transform.position.x;
        save.Monster0PositionZ = Monster0.transform.position.z;
        save.Monster0RotationY = Monster0.transform.rotation.y;
        save.Monster0Alive = monster0.GetComponent<MonsterWordController>().Alive;
        save.Monster0Found = Monster0Found;

        save.Monster1Hp = Monster1Hp;
        save.Monster1PositionX = Monster1.transform.position.x;
        save.Monster1PositionZ = Monster1.transform.position.z;
        save.Monster1RotationY = Monster1.transform.rotation.y;
        save.Monster1Alive = monster1.GetComponent<MonsterController>().Alive;
        save.Monster1Found = Monster1Found;

        save.Monster2Hp = Monster2Hp;
        save.Monster2PositionX = Monster2.transform.position.x;
        save.Monster2PositionZ = Monster2.transform.position.z;
        save.Monster2RotationY = Monster2.transform.rotation.y;
        save.Monster2Alive = monster2.GetComponent<MonsterController>().Alive;
        save.Monster2Found = Monster2Found;

        save.Monster3Hp = Monster3Hp;
        save.Monster3PositionX = Monster3.transform.position.x;
        save.Monster3PositionZ = Monster3.transform.position.z;
        save.Monster0RotationY = Monster3.transform.rotation.y;
        save.Monster3Alive = monster3.GetComponent<MonsterController>().Alive;
        save.Monster3Found = Monster3Found;

        save.Monster4Hp = Monster4Hp;
        save.Monster4PositionX = Monster4.transform.position.x;
        save.Monster4PositionZ = Monster4.transform.position.z;
        save.Monster4RotationY = Monster4.transform.rotation.y;
        save.Monster4Alive = monster4.GetComponent<MonsterController>().Alive;
        save.Monster4Found = Monster4Found;

        save.Monster5Hp = Monster5Hp;
        save.Monster5PositionX = Monster5.transform.position.x;
        save.Monster5PositionZ = Monster5.transform.position.z;
        save.Monster5RotationY = Monster5.transform.rotation.y;
        save.Monster5Alive = monster5.GetComponent<MonsterController>().Alive;
        save.Monster5Found = Monster5Found;

        save.Monster6Hp = Monster6Hp;
        save.Monster6PositionX = Monster6.transform.position.x;
        save.Monster6PositionZ = Monster6.transform.position.z;
        save.Monster6RotationY = Monster6.transform.rotation.y;
        save.Monster6Alive = monster6.GetComponent<MonsterController>().Alive;
        save.Monster6Found = Monster6Found;

        save.Monster7Hp = Monster7Hp;
        save.Monster7PositionX = Monster7.transform.position.x;
        save.Monster7PositionZ = Monster7.transform.position.z;
        save.Monster7RotationY = Monster7.transform.rotation.y;
        save.Monster7Alive = monster7.GetComponent<MonsterController>().Alive;
        save.Monster7Found = Monster7Found;

        save.Monster8Hp = Monster8Hp;
        save.Monster8PositionX = Monster8.transform.position.x;
        save.Monster8PositionZ = Monster8.transform.position.z;
        save.Monster8RotationY = Monster8.transform.rotation.y;
        save.Monster8Alive = monster8.GetComponent<MonsterController>().Alive;
        save.Monster8Found = Monster8Found;

        save.Monster9Hp = Monster9Hp;
        save.Monster9PositionX = Monster9.transform.position.x;
        save.Monster9PositionZ = Monster9.transform.position.z;
        save.Monster9RotationY = Monster9.transform.rotation.y;
        save.Monster9Alive = monster9.GetComponent<MonsterController>().Alive;
        save.Monster9Found = Monster9Found;

        save.Monster10Hp = Monster10Hp;
        save.Monster10PositionX = Monster10.transform.position.x;
        save.Monster10PositionZ = Monster10.transform.position.z;
        save.Monster10RotationY = Monster10.transform.rotation.y;
        save.Monster10Alive = monster10.GetComponent<MonsterController>().Alive;
        save.Monster10Found = Monster10Found;

        save.Monster11Hp = Monster11Hp;
        save.Monster11PositionX = Monster11.transform.position.x;
        save.Monster11PositionZ = Monster11.transform.position.z;
        save.Monster11RotationY = Monster11.transform.rotation.y;
        save.Monster11Alive = monster11.GetComponent<MonsterController>().Alive;
        save.Monster11Found = Monster11Found;

        save.Monster12Hp = Monster12Hp;
        save.Monster12PositionX = Monster12.transform.position.x;
        save.Monster12PositionZ = Monster12.transform.position.z;
        save.Monster12RotationY = Monster12.transform.rotation.y;
        save.Monster12Alive = monster12.GetComponent<MonsterController>().Alive;
        save.Monster12Found = Monster12Found;

        save.Monster13Hp = Monster13Hp;
        save.Monster13PositionX = Monster13.transform.position.x;
        save.Monster13PositionZ = Monster13.transform.position.z;
        save.Monster13RotationY = Monster13.transform.rotation.y;
        save.Monster13Alive = monster13.GetComponent<MonsterController>().Alive;
        save.Monster13Found = Monster13Found;

        save.Monster14Hp = Monster14Hp;
        save.Monster14PositionX = Monster14.transform.position.x;
        save.Monster14PositionZ = Monster14.transform.position.z;
        save.Monster14RotationY = Monster14.transform.rotation.y;
        save.Monster14Alive = monster14.GetComponent<MonsterController>().Alive;
        save.Monster14Found = Monster14Found;

        save.Monster15Hp = Monster15Hp;
        save.Monster15PositionX = Monster15.transform.position.x;
        save.Monster15PositionZ = Monster15.transform.position.z;
        save.Monster15RotationY = Monster15.transform.rotation.y;
        save.Monster15Alive = monster15.GetComponent<MonsterController>().Alive;
        save.Monster15Found = Monster15Found;

        save.Monster16Hp = Monster16Hp;
        save.Monster16PositionX = Monster16.transform.position.x;
        save.Monster16PositionZ = Monster16.transform.position.z;
        save.Monster16RotationY = Monster16.transform.rotation.y;
        save.Monster16Alive = monster16.GetComponent<MonsterController>().Alive;
        save.Monster16Found = Monster16Found;

        save.Monster17Hp = Monster17Hp;
        save.Monster17PositionX = Monster17.transform.position.x;
        save.Monster17PositionZ = Monster17.transform.position.z;
        save.Monster17RotationY = Monster17.transform.rotation.y;
        save.Monster17Alive = monster17.GetComponent<MonsterController>().Alive;
        save.Monster17Found = Monster17Found;

        return save;
    }
    

    public void LoadGame()
    {
        audioController.Btn = true;
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();
            Player.transform.position = new Vector3(save.PlayerPositionX, 0, save.PlayerPositionZ);
            Player.transform.rotation = new Quaternion(0, save.PlayerRotationY, 0, 0);

            LoveFireCD = save.LoveFireCD;
            LoadLoveCD = true;

            GunDone = save.GunDone;
            BowDone = save.BowDone;
            PanDone = save.PanDone;
            IronDone = save.IronDone;
            LoveDone = save.LoveDone;
            LaserDone = save.LaserDone;

            UDone = save.UDone;
            BDone = save.BDone;
            WDone = save.WDone;
            PDone = save.PDone;
            IDone = save.IDone;
            RDone = save.RDone;
            VDone = save.VDone;
            SDone = save.SDone;

            BagDone = save.BagDone;

            BagPage.gunPhare = save.gunPhare;
            BagPage.bowPhare = save.bowPhare;
            BagPage.panPhare = save.panPhare;
            BagPage.ironPhare = save.ironPhare;
            BagPage.lovePhare = save.lovePhare;
            BagPage.laserPhare = save.laserPhare;

            WeopenController.useWhatWeopen = save.useWhatWeopen;

            dieTime = save.dieTime;

            FirstRoomPortalDone = save.FirstRoomPortalDone;

            firstRoomStarted = save.firstRoomStarted;
            mainRoomStarted = save.mainRoomStarted;

            playerHp = save.playerHp;
            isLoadHp = true;

            if (save.MonsterTAlive == false)
            {
                MonsterT.SetActive(false);
                MonsterTHp = 0;
                MonsterT.transform.position = new Vector3(save.MonsterTPositionX, 0, save.MonsterTPositionZ);
                if (save.BDone == false)
                {
                    Instantiate(WordB, MonsterT.transform.position, MonsterT.transform.rotation);
                }
            }
            else
            {
                MonsterTHp = save.MonsterTHp;
                MonsterT.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster0Alive == false)
            {
                Monster0.SetActive(false);
                Monster0Hp = 0;
                Monster0.transform.position = new Vector3(save.Monster0PositionX, 0, save.Monster0PositionZ);
                Debug.Log(save.RDone);
                if (save.RDone == false)
                {
                    Instantiate(WordR, Monster0.transform.position, Monster0.transform.rotation);
                }
            }
            else
            {
                Monster0Hp = save.Monster0Hp;
                Monster0.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            monsterT.GetComponent<MonsterWordController>().Alive = save.MonsterTAlive;
            monster0.GetComponent<MonsterWordController>().Alive = save.Monster0Alive;
            monster1.GetComponent<MonsterController>().Alive = save.Monster1Alive;
            monster2.GetComponent<MonsterController>().Alive = save.Monster2Alive;
            monster3.GetComponent<MonsterController>().Alive = save.Monster3Alive;
            monster4.GetComponent<MonsterController>().Alive = save.Monster4Alive;
            monster5.GetComponent<MonsterController>().Alive = save.Monster5Alive;
            monster6.GetComponent<MonsterController>().Alive = save.Monster6Alive;
            monster7.GetComponent<MonsterController>().Alive = save.Monster7Alive;
            monster8.GetComponent<MonsterController>().Alive = save.Monster8Alive;
            monster9.GetComponent<MonsterController>().Alive = save.Monster9Alive;
            monster10.GetComponent<MonsterController>().Alive = save.Monster10Alive;
            monster11.GetComponent<MonsterController>().Alive = save.Monster11Alive;
            monster12.GetComponent<MonsterController>().Alive = save.Monster12Alive;
            monster13.GetComponent<MonsterController>().Alive = save.Monster13Alive;
            monster14.GetComponent<MonsterController>().Alive = save.Monster14Alive;
            monster15.GetComponent<MonsterController>().Alive = save.Monster15Alive;
            monster16.GetComponent<MonsterController>().Alive = save.Monster16Alive;
            monster17.GetComponent<MonsterController>().Alive = save.Monster17Alive;

            MonsterTFound = save.MonsterTFound;
            Monster0Found = save.Monster0Found;
            Monster1Found = save.Monster1Found;
            Monster2Found = save.Monster2Found;
            Monster3Found = save.Monster3Found;
            Monster4Found = save.Monster4Found;
            Monster5Found = save.Monster5Found;
            Monster6Found = save.Monster6Found;
            Monster7Found = save.Monster7Found;
            Monster8Found = save.Monster8Found;
            Monster9Found = save.Monster9Found;
            Monster10Found = save.Monster10Found;
            Monster11Found = save.Monster11Found;
            Monster12Found = save.Monster12Found;
            Monster13Found = save.Monster13Found;
            Monster14Found = save.Monster14Found;
            Monster15Found = save.Monster15Found;
            Monster16Found = save.Monster16Found;
            Monster17Found = save.Monster17Found;

            if (MonsterTFound == true && save.MonsterTAlive == true)
                mT.foundPlayer = true;

            if (Monster0Found == true && save.Monster0Alive == true)
                m0.foundPlayer = true;

            if (Monster1Found == true && save.Monster1Alive == true)
                m1.foundPlayer = true;

            if (Monster2Found == true && save.Monster2Alive == true)
                m2.foundPlayer = true;

            if (Monster3Found == true && save.Monster3Alive == true)
                m3.foundPlayer = true;

            if (Monster4Found == true && save.Monster4Alive == true)
                m4.foundPlayer = true;

            if (Monster5Found == true && save.Monster5Alive == true)
                m5.foundPlayer = true;

            if (Monster6Found == true && save.Monster6Alive == true)
                m6.foundPlayer = true;

            if (Monster7Found == true && save.Monster7Alive == true)
                m7.foundPlayer = true;

            if (Monster8Found == true && save.Monster8Alive == true)
                m8.foundPlayer = true;

            if (Monster9Found == true && save.Monster9Alive == true)
                m9.foundPlayer = true;

            if (Monster10Found == true && save.Monster10Alive == true)
                m10.foundPlayer = true;

            if (Monster11Found == true && save.Monster11Alive == true)
                m11.foundPlayer = true;

            if (Monster12Found == true && save.Monster12Alive == true)
                m12.foundPlayer = true;

            if (Monster13Found == true && save.Monster13Alive == true)
                m13.foundPlayer = true;

            if (Monster14Found == true && save.Monster14Alive == true)
                m14.foundPlayer = true;

            if (Monster15Found == true && save.Monster15Alive == true)
                m15.foundPlayer = true;

            if (Monster16Found == true && save.Monster16Alive == true)
                m16.foundPlayer = true;

            if (Monster17Found == true && save.Monster17Alive == true)
                m17.foundPlayer = true;

            if (save.Monster1Alive == false)
            {
                Monster1.SetActive(false);
                Monster1Hp = 0;
            }
            else
            {
                Monster1Hp = save.Monster1Hp;
                Monster1.transform.position = new Vector3(save.Monster1PositionX, 0, save.Monster1PositionZ);
                Monster1.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster2Alive == false)
            {
                Monster2.SetActive(false);
                Monster2Hp = 0;
            }
            else
            {
                Monster2Hp = save.Monster2Hp;
                Monster2.transform.position = new Vector3(save.Monster2PositionX, 0, save.Monster2PositionZ);
                Monster2.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster3Alive == false)
            {
                Monster3.SetActive(false);
                Monster3Hp = 0;
            }
            else
            {
                Monster3Hp = save.Monster3Hp;
                Monster3.transform.position = new Vector3(save.Monster3PositionX, 0, save.Monster3PositionZ);
                Monster3.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster4Alive == false)
            {
                Monster4.SetActive(false);
                Monster4Hp = 0;
            }
            else
            {
                Monster4Hp = save.Monster4Hp;
                Monster4.transform.position = new Vector3(save.Monster4PositionX, 0, save.Monster4PositionZ);
                Monster4.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster5Alive == false)
            {
                Monster5.SetActive(false);
                Monster5Hp = 0;
            }
            else
            {
                Monster5Hp = save.Monster5Hp;
                Monster5.transform.position = new Vector3(save.Monster5PositionX, 0, save.Monster5PositionZ);
                Monster5.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster6Alive == false)
            {
                Monster6.SetActive(false);
                Monster6Hp = 0;
            }
            else
            {
                Monster6Hp = save.Monster6Hp;
                Monster6.transform.position = new Vector3(save.Monster6PositionX, 0, save.Monster6PositionZ);
                Monster6.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster7Alive == false)
            {
                Monster7.SetActive(false);
                Monster7Hp = 0;
            }
            else
            {
                Monster7Hp = save.Monster7Hp;
                Monster7.transform.position = new Vector3(save.Monster7PositionX, 0, save.Monster7PositionZ);
                Monster7.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster8Alive == false)
            {
                Monster8.SetActive(false);
                Monster8Hp = 0;
            }
            else
            {
                Monster8Hp = save.Monster8Hp;
                Monster8.transform.position = new Vector3(save.Monster8PositionX, 0, save.Monster8PositionZ);
                Monster8.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster9Alive == false)
            {
                Monster9.SetActive(false);
                Monster9Hp = 0;
            }
            else
            {
                Monster9Hp = save.Monster9Hp;
                Monster9.transform.position = new Vector3(save.Monster9PositionX, 0, save.Monster9PositionZ);
                Monster9.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster10Alive == false)
            {
                Monster10.SetActive(false);
                Monster10Hp = 0;
            }
            else
            {
                Monster10Hp = save.Monster10Hp;
                Monster10.transform.position = new Vector3(save.Monster10PositionX, 0, save.Monster10PositionZ);
                Monster10.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster11Alive == false)
            {
                Monster11.SetActive(false);
                Monster11Hp = 0;
            }
            else
            {
                Monster11Hp = save.Monster11Hp;
                Monster11.transform.position = new Vector3(save.Monster11PositionX, 0, save.Monster11PositionZ);
                Monster11.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster12Alive == false)
            {
                Monster12.SetActive(false);
                Monster12Hp = 0;
            }
            else
            {
                Monster12Hp = save.Monster12Hp;
                Monster12.transform.position = new Vector3(save.Monster12PositionX, 0, save.Monster12PositionZ);
                Monster12.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster13Alive == false)
            {
                Monster13.SetActive(false);
                Monster13Hp = 0;
            }
            else
            {
                Monster13Hp = save.Monster13Hp;
                Monster13.transform.position = new Vector3(save.Monster13PositionX, 0, save.Monster13PositionZ);
                Monster13.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }
            
            if (save.Monster14Alive == false)
            {
                Monster14.SetActive(false);
                Monster14Hp = 0;
            }
            else
            {
                Monster14Hp = save.Monster14Hp;
                Monster14.transform.position = new Vector3(save.Monster14PositionX, 0, save.Monster14PositionZ);
                Monster14.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster15Alive == false)
            {
                Monster15.SetActive(false);
                Monster15Hp = 0;
            }
            else
            {
                Monster15Hp = save.Monster15Hp;
                Monster15.transform.position = new Vector3(save.Monster15PositionX, 0, save.Monster15PositionZ);
                Monster15.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster16Alive == false)
            {
                Monster16.SetActive(false);
                Monster16Hp = 0;
            }
            else
            {
                Monster16Hp = save.Monster16Hp;
                Monster16.transform.position = new Vector3(save.Monster16PositionX, 0, save.Monster16PositionZ);
                Monster16.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }

            if (save.Monster17Alive == false)
            {
                Monster17.SetActive(false);
                Monster17Hp = 0;
            }
            else
            {
                Monster17Hp = save.Monster17Hp;
                Monster17.transform.position = new Vector3(save.Monster17PositionX, 0, save.Monster17PositionZ);
                Monster17.transform.rotation = Quaternion.LookRotation(Player.transform.position);
            }           

            if (save.scene == 0 && scene != 0)
            {
                ChangeRoom.GoToFirstRoom();
                DontDestroyOnLoad(Controller);
                DontDestroyOnLoad(Player);
                DontDestroyOnLoad(MainCamare);
                MainCamare.orthographicSize = 5;
                DontDestroyOnLoad(UI);
                DontDestroyOnLoad(MonsterRoot);
                DontDestroyOnLoad(MonsterTSearch);
                scene = 0;
                MonsterRoot.SetActive(false);
                MonsterTSearch.SetActive(true);
            }
            else if (save.scene == 1 && scene != 1)
            {
                ChangeRoom.GoToMainRoom();
                DontDestroyOnLoad(Controller);
                DontDestroyOnLoad(Player);
                DontDestroyOnLoad(MainCamare);
                MainCamare.orthographicSize = 5;
                DontDestroyOnLoad(UI);
                DontDestroyOnLoad(MonsterRoot);
                DontDestroyOnLoad(MonsterTSearch);
                scene = 1;
                MonsterRoot.SetActive(true);
                MonsterTSearch.SetActive(false);
            }
            /*
            else
            {
                ChangeRoom.boss房间
            }
            */
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

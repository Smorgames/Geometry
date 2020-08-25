//using UnityEngine;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//public static class SaveSystem
//{
//    public static void SavePlayer(PlayerController player)
//    {
//        BinaryFormatter formatter = new BinaryFormatter();
//        string path = Application.persistentDataPath + "/player.txt";
//        FileStream stream = new FileStream(path, FileMode.Create);

//        PlayerData data = new PlayerData(player);

//        formatter.Serialize(stream, data);
//        stream.Close();
//    }

//    public static PlayerData LoadPlayer()
//    {
//        string path = Application.persistentDataPath + "/player.txt";

//        BinaryFormatter formatter = new BinaryFormatter();
//        FileStream stream = new FileStream(path, FileMode.Open);

//        PlayerData data = formatter.Deserialize(stream) as PlayerData;
//        stream.Close();
//        return data;
//    }

//    public static void Clear()
//    {
//        BinaryFormatter formatter = new BinaryFormatter();
//        string path = Application.persistentDataPath + "/player.txt";
//        FileStream stream = new FileStream(path, FileMode.Truncate);
//        stream.Close();
//    }
//}

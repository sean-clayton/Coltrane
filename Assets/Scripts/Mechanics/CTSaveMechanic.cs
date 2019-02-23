using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class CTSaveMechanic
{
    const string playerDataFileName = "playerdata.ctdata";

    public static void SavePlayer(CTPlayableCharacter player)
    {
        const string playerDataFileName = "playerdata.ctdata";

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + playerDataFileName;

        FileStream stream = new FileStream(path, FileMode.Create);

        CTGameState data = new CTGameState(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static CTGameState LoadPlayer()
    {
        string path = Application.persistentDataPath + "/" + playerDataFileName;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            CTGameState data = formatter.Deserialize(stream) as CTGameState;
            stream.Close();

            return data;
        }
        else
        {
            return null;
        }
    }
}

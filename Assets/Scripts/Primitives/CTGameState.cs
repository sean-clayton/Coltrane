[System.Serializable]
public class CTGameState
{
    public int playerExperience;
    public int playerHealth;
    public int playerEnergyLevel;
    public float[] position;

    public CTGameState(CTPlayableCharacter player)
    {
        playerExperience = player.experience;
        playerHealth = player.health;
        playerEnergyLevel = player.energyLevel;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}

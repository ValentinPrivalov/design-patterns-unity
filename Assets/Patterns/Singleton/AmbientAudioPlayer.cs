using UnityEngine;

public class AmbientAudioPlayer
{
    private static AmbientAudioPlayer instance = null;

    public static AmbientAudioPlayer GetInstance()
    {
        if (instance == null)
        {
            instance = new AmbientAudioPlayer();
        }
        return instance;
    }

    // private - this class can be created only here
    private AmbientAudioPlayer()
    {
    }
}

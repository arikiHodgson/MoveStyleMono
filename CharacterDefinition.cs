using UnityEngine;

namespace CrewBoomMonobehaviours
{
    [AddComponentMenu("Crew Boom/Character Definition")]
    public class CharacterDefinition : MonoBehaviour
    {
        public bool IsNewCharacter;
        public BrcCharacter CharacterToReplace;

        public string CharacterName = "New Custom Character";

        public Material[] Outfits;
        public bool UseReptileShader = true;

        public Material Graffiti;
        public string GraffitiName;
        public string GraffitiArtist;

        public AudioClip[] VoiceDie;
        public AudioClip[] VoiceDieFall;
        public AudioClip[] VoiceTalk;
        public AudioClip[] VoiceBoostTrick;
        public AudioClip[] VoiceCombo;
        public AudioClip[] VoiceGetHit;
        public AudioClip[] VoiceJump;

        public bool CanBlink;

        public string Id;
    }
}
using System;
using UnityEngine;

namespace BrcCustomCharactersLib
{
    [AddComponentMenu("BRC Custom Characters/Character Definition")]
    public class CharacterDefinition : MonoBehaviour
    {
        public BrcNamedCharacter CharacterToReplace;

        public string CharacterName = "New Custom Character";

        public Material[] Outfits;
        public bool UseReptileShader = true;

        public Material Graffiti;
        public string GraffitiName;

        public AudioClip[] VoiceDie;
        public AudioClip[] VoiceDieFall;
        public AudioClip[] VoiceTalk;
        public AudioClip[] VoiceBoostTrick;
        public AudioClip[] VoiceCombo;
        public AudioClip[] VoiceGetHit;
        public AudioClip[] VoiceJump;

        public int _blinkBlendShapeIndex;

        public string Id;
    }
}
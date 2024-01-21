using System;
using UnityEngine;
using System.Collections.Generic;

namespace MoveStylerMono
{
    [AddComponentMenu("MoveStyler/Movestyle Definition")]
    public class MoveStyleDefinition : MonoBehaviour
    {
        public string Movestylename = "New Custom Movestyle";
        //public BrcCharacter FreestyleAnimation = BrcCharacter.Red;
        //public BrcCharacter BounceAnimation = BrcCharacter.Red;
        public BrcMovestyle ParentMovestyle = BrcMovestyle.Skateboard;
        //public bool UseHandIK = false;
        // Split the hand IK defaults
        public bool UseHandRIK = false;
        public bool UseHandLIK = false;

        public MeshRenderer[] PropRenderers;
        public string[] PropAttachmentBones;
        //public KeyValuePair<MeshRenderer, string>[] Props;
        public Animator StyleAnimator;

        //public CustomMovementStats CustomMoveStats;

        //Custom Movement Stats
        public float runSpeed = 6.5f;
        public float walkSpeed = 1.8f;
        public float groundAcc = 16.5f;
        public float groundDecc = 24.9f;
        public float airAcc = 9.95F;
        public float airDecc = 2.0f;
        public float rotSpeedAtMaxSpeed = 8.0f;
        public float rotSpeedAtStill = 40f;
        public float rotSpeedInAir = 1.45f;
        public float grindSpeed = 11.5f;
        public float slideDeccHighSpeed = 2.5f;
        public float slideDeccLowSpeed = 3.8f;

        public CustomAnimInfo[] AnimationInfoOverrides;

        //This really sucks but I have to do it as Unity still doesn't support serialized types from a DLL
        //that isn't shipped with the game itself but loaded with Assembly.Load (which BepInEx probably does)
        //It also doesn't serialize multi-dimensional arrays so even that doesn't work

        // **** Add styles to custom movestyles
        //public CharacterOutfit[] Outfits;

        // **** Rework audio for movestyle
        public CustomSFXCollection SFXCollection;

        // **** Audio Overrides

        public AudioClip[] Jump;
        public AudioClip[] Land;
        public AudioClip[] Run;
        public AudioClip[] Wallrun;
        public AudioClip[] Slide;
        public AudioClip[] Grind;
        public AudioClip[] GroundTrick1;
        public AudioClip[] GroundTrick2;
        public AudioClip[] GroundTrick3;
        public AudioClip[] AirTrick1;
        public AudioClip[] AirTrick2;
        public AudioClip[] AirTrick3;
        public AudioClip[] GrindTrick1;
        public AudioClip[] GrindTrick2;
        public AudioClip[] GrindTrick3;
        public AudioClip[] HandPlant;

            // **** Custom Audio Clips
        public AudioClip[] CustomAudioClips;
        public int[] AudioClipID;

        public string Id;

        public int Index;

    }

    [System.Serializable]
    public class MovestyleConfig
    {
        public List<CustomAnimInfo> CustomAnimationInfo;
    }

    [System.Serializable]
    public class CustomAnimInfo
    {
        // Token: 0x0600266D RID: 9837 RVA: 0x000B9AC8 File Offset: 0x000B7CC8
        /*
		public CustomAnimInfo(string animName, _AnimType setAnimType = _AnimType.NORMAL, string nextAnimation = "", float setInterruptIntoFallFrom = 0f, float nextAnimationAtTime = 0f, float setDuration = 1f)
		{
			//player.animInfosSets[(int)player.moveStyle].Add(Animator.StringToHash(name), this);
			this.nextAnim = Animator.StringToHash(nextAnimation);
			this.animName = animName;
			this.animType = setAnimType;
			this.duration = setDuration;
			this.nextAnimAtTime = nextAnimationAtTime;
			this.interruptIntoFallFrom = setInterruptIntoFallFrom;
		} */

        public string animName;

        public animFade[] _fadeFrom;
        public animFade[] _fadeTo;

        // Token: 0x04002765 RID: 10085
        public string nextAnim;
        // Token: 0x04002766 RID: 10086
        public float nextAnimAtTime = 0.0f;
        // Token: 0x04002767 RID: 10087
        public float duration = 1.0f;
        // Token: 0x04002768 RID: 10088
        public bool lHandIKOverride;
        public bool rHandIKOverride;
        public bool feetIK;
        // Token: 0x04002769 RID: 10089
        public _AnimType animType;
        // Token: 0x0400276A RID: 10090
        public bool skipStartrun;
        // Token: 0x0400276B RID: 10091
        public float interruptIntoFallFrom;
    }
    public enum _AnimType
    {
        // Token: 0x0400276D RID: 10093
        NORMAL,
        // Token: 0x0400276E RID: 10094
        IDLE,
        // Token: 0x0400276F RID: 10095
        RUN,
        // Token: 0x04002770 RID: 10096
        STOPRUN,
        // Token: 0x04002771 RID: 10097
        LAND,
        // Token: 0x04002772 RID: 10098
        OVERRULE_IDLE,
        // Token: 0x04002773 RID: 10099
        AIRTRICK,
        // Token: 0x04002774 RID: 10100
        GROUNDTRICK
    }

    [Serializable]
    public struct animFade
    {
        public animFade(string _animName, float _fadeDuration)
        {
            animName = _animName;
            fadeDuration = _fadeDuration;
        }

        public string animName;
        public float fadeDuration;

    }

    [System.Serializable]
    public class CustomSFXCollection
    {

        public AudioClip[] Jump;
        public AudioClip[] Land;
        public AudioClip[] Run;
        public AudioClip[] Wallrun;
        public AudioClip[] Slide;
        public AudioClip[] Grind;
        public AudioClip[] GroundTrick1;
        public AudioClip[] GroundTrick2;
        public AudioClip[] GroundTrick3;
        public AudioClip[] AirTrick1;
        public AudioClip[] AirTrick2;
        public AudioClip[] AirTrick3;
        public AudioClip[] GrindTrick1;
        public AudioClip[] GrindTrick2;
        public AudioClip[] GrindTrick3;
        public AudioClip[] HandPlant;

        //Allows players to add their own custom sounds to trigger when they want
        // <AnimID, Clips>
        public AudioClip[] CustomSFX;
        public int[] CustomSFXID;

        public CustomClipDefinition[] CustomClips;

    }

    [Serializable]
    public struct CustomClipDefinition
    {
        public CustomClipDefinition(int _ID, AudioClip[] _audioClips)
        {
            ID = _ID;
            audioClips = _audioClips;
        }


        public  int ID;
        public AudioClip[] audioClips;
    }
}
using System;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;
using UnityEngine.PlayerLoop;

namespace Menu.Runtime.TalkingTrack
{
    [SerializeField]
    public class TalkingTextClipBehaviour : PlayableBehaviour
    {
        private GameObject TextUIGameObject;
        public TalkingTextClip TalkingTextClipClass;
        public string ConversationContent;
        private TextMeshProUGUI _TextMeshPro;
        private string CharacterName;
        private bool ClipOnce = true;
        
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            TextUIGameObject = playerData as GameObject;
            
            if (ClipOnce)
            {
                ClipOnce = false;
                
                ConversationContent = TalkingTextClipClass.ConversationContent;
                _TextMeshPro = TextUIGameObject.GetComponent<TextMeshProUGUI>();
            }
            
            _TextMeshPro.SetText(ConversationContent);
        }
    }

}


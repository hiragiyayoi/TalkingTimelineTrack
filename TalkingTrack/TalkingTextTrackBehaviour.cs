using System;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

namespace Menu.Runtime.TalkingTrack
{
    [SerializeField]
    public class TalkingTextTrackBehaviour : PlayableBehaviour
    {
        public TalkingTextTrack TalkingTextTrackClass;
        
        private GameObject TextUIGameObject;
        private float ClipWeight, _ClipCountlength;
        private string ConversationContent;
        private TextMeshProUGUI _TextMeshPro;
        private bool once = true;
        
        public override void OnGraphStart(Playable playable)
        {
            _ClipCountlength = playable.GetInputCount();
        }
        
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {   
            TextUIGameObject = playerData as GameObject;
            ClipWeight = 0;
            
            for (int ClipNum = 0; _ClipCountlength > ClipNum; ClipNum += 1)
            {
                ClipWeight += playable.GetInputWeight(ClipNum);
            }

            if(ClipWeight == 0)
            {
                if (once)
                {
                    _TextMeshPro = TextUIGameObject.GetComponent<TextMeshProUGUI>();
                
                    _TextMeshPro.SetText("");
                    once = false;
                }
            }
            else
            {
                once = true;
            }
        }
    }


}


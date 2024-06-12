using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UIElements;
using UnityEditor;


namespace Menu.Runtime.TalkingTrack
{
    [Serializable]
    public class TalkingTextClip : PlayableAsset, ITimelineClipAsset
    {
        public ClipCaps clipCaps => ClipCaps.None;
        [TextArea(1,6)]
        public string ConversationContent;
        
        private TalkingTextClipBehaviour TalkingTextClipBehaviourClass;
        private TalkingTextTrack TalkingTextTrackClass;
        
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<TalkingTextClipBehaviour>.Create(graph, TalkingTextClipBehaviourClass);
            var behaviour = playable.GetBehaviour();
            behaviour.TalkingTextClipClass = this;
            
            return playable;
        }
        
        /*public void OnDestroy()
        {
            TalkingTextTrackClass.ClipNum -= 1;
            Debug.Log("ssss");
        }*/
    }

}


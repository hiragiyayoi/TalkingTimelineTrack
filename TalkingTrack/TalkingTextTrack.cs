using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEditor;
using UnityEngine.Playables;
using Alchemy;
using Alchemy.Inspector;

namespace Menu.Runtime.TalkingTrack
{
    [TrackClipType(typeof(TalkingTextClip))]
    [TrackBindingType(typeof(GameObject))]
    public class TalkingTextTrack : TrackAsset
    {
        public string Name;
        public Position _Position;
        public int ClipNum = 0;
        
        private string _ClipName;
        private TalkingTextClip TalkingTextClipClass;
        
        
        public enum Position //stringと同様の扱い
        {
            Left, Right
        }

        protected override void OnCreateClip(TimelineClip clip)
        {
            var asset = clip.asset as TalkingTextClip;

            _ClipName = Name + " Talk" + $" ({Convert.ToString(ClipNum)})";
            
            clip.displayName = _ClipName;
            
            ClipNum += 1;
        }
        
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            var playable = ScriptPlayable<TalkingTextTrackBehaviour>.Create(graph, inputCount);//どのPlayableBehaviourで実行させるか指定する．
            var behaviour = playable.GetBehaviour();
            behaviour.TalkingTextTrackClass = this;

            return playable;
        }
    }
}



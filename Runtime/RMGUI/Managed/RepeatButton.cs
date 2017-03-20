// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

namespace UnityEngine.Experimental.RMGUI
{
    [GUISkinStyle("button")]
    public class RepeatButton : VisualElement
    {
        public RepeatButton(ClickEvent clickEvent, long delay, long interval)
        {
            AddManipulator(new Clickable(clickEvent, delay, interval));
        }
    }
}
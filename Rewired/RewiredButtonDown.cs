using NodeCanvas.Framework;

using ParadoxNotion.Design;
using Rewired;

namespace scg
{
    [Category("Rewired")]
    public class RewiredButtonDown : ConditionTask
    {

        public BBParameter<Player> player;
        public BBParameter<string> buttonName;
        public BBParameter<bool> buttonState;

        protected override bool OnCheck()
        {
            buttonState.value = player.value.GetButtonDown(buttonName.value);
            return buttonState.value;
        }

    }
}

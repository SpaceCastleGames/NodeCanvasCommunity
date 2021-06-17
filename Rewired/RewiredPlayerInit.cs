using NodeCanvas.Framework;
using Rewired;
using ParadoxNotion.Design;

namespace scg
{
    [Category("Rewired")]
    public class RewiredPlayerInit : ActionTask
    {

        public BBParameter<int> playerId;
        public BBParameter<Player> rewiredPlayer;

        protected override void OnExecute()
        {
            rewiredPlayer.value = ReInput.players.GetPlayer(playerId.value);
            EndAction(true);
        }

    }
}

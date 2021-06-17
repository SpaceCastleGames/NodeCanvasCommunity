using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace HaywireStudio.MicroManagerSoccer
{
    [Category("Networking (Mirror)")]
    public class SendMessageToNetworkServer : ActionTask
    {
        private BTNetworkBehaviours _networkBehaviors;
        public BBParameter<BTNetworkBehaviours> NetworkBehaviors;
        public BBParameter<string> NetworkMethodName;
        public BBParameter<string> NetworkParameterValue;

        protected override string info
        {
            get
            {
                return string.Format("Send Message To Network Server");
            }
        }

        protected override void OnUpdate()
        {
            if (_networkBehaviors == null)
            {
                _networkBehaviors = NetworkBehaviors.value;
                if (_networkBehaviors == null)
                {
                    EndAction(false);
                    return;
                }
            }

            if (_networkBehaviors.hasAuthority)
            {
                var theMethod = _networkBehaviors.GetType().GetMethod(NetworkMethodName.value);
                var arguments = new object[] { NetworkParameterValue.value };
                theMethod.Invoke(_networkBehaviors, arguments);
            }

            EndAction(true);
        }
    }
}

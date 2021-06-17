using NodeCanvas.Framework;
using TMPro;
using UnityEngine;

namespace scg
{
    public class AnimateTextAction : ActionTask
    {

        public BBParameter<TextMeshProUGUI> textMeshPro;
        public BBParameter<string> text;
        public BBParameter<float> delay=0.05f;
        private float elapseTime=0;

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {
            textMeshPro.value.text = text.value;
            textMeshPro.value.maxVisibleCharacters = 0;
        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {
            while (textMeshPro.value.maxVisibleCharacters <= text.value.Length)
            {
                if(elapseTime <= delay.value)
                {
                    elapseTime += Time.deltaTime;
                    return;
                }
                elapseTime = 0;
                textMeshPro.value.maxVisibleCharacters++;
            }
            EndAction(true);
        }

    }
}

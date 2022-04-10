using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;

namespace WithLithum.Core.Policing.Utils
{
    /// <summary>
    /// Represents a list of dialogues.
    /// </summary>
    public class DialogueList
    {
        private readonly List<IDialogue> dialogues = new List<IDialogue>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueList"/> class.
        /// </summary>
        /// <param name="subject">The subject.</param>
        public DialogueList(Ped subject)
        {
            this.Subject = subject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueList"/> class.
        /// </summary>
        /// <param name="dialogues">The dialogues.</param>
        /// <param name="subject">The subject ped.</param>
        public DialogueList(Ped subject, IDialogue[] dialogues)
        {
            Subject = subject;
            foreach (var item in dialogues)
            {
                this.dialogues.Add(item);
            }
        }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        /// <value>
        /// The current position.
        /// </value>
        public int CurrentPosition { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public Ped Subject { get; set; }

        /// <summary>
        /// Triggers this instance.
        /// </summary>
        public void Trigger()
        {
            var dialogue = dialogues[CurrentPosition++];
            Game.DisplaySubtitle($"~b~{dialogue.Speaker}~w~: ");
            dialogue.Callback?.Invoke(Subject);
        }
    }
}

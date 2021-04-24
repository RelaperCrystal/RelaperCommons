using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPD_First_Response.Mod.API;
using Rage;

namespace RelaperCommons.Utils.Dialogues
{
    /// <summary>
    /// Represents a dialogue triggers a pursuit.
    /// </summary>
    /// <seealso cref="TextDialogue" />
    public class FleeDialogue : TextDialogue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleeDialogue"/> class.
        /// </summary>
        /// <param name="speaker">The speaker.</param>
        /// <param name="text">The text.</param>
        public FleeDialogue(string speaker, string text) : base(speaker, text)
        {
            this.Callback = new Action<Ped>(Flee);
        }

        /// <summary>
        /// Gets the pursuit triggered by this dialogue, or <see langword="null"/> if no pursuit is triggered.
        /// </summary>
        /// <value>
        /// The pursuit triggered by this dialogue, or <see langword="null"/> if no pursuit is triggered.
        /// </value>
        public LHandle Pursuit { get; private set; }

        private void Flee(Ped subject)
        {
            Pursuit = Functions.CreatePursuit();
            Functions.AddPedToPursuit(Pursuit, subject);
            Functions.SetPursuitIsActiveForPlayer(Pursuit, true);
            Functions.SetPursuitCopsCanJoin(Pursuit, true);
        }
    }
}

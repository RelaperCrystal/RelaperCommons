using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;

namespace RelaperCommons.Utils.Dialogues
{
    /// <summary>
    /// Represents a dialogue with nothing but text.
    /// </summary>
    /// <seealso cref="RelaperCommons.Utils.IDialogue" />
    public class TextDialogue : IDialogue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextDialogue"/> class.
        /// </summary>
        /// <param name="speaker">The speaker.</param>
        /// <param name="text">The text.</param>
        public TextDialogue(string speaker, string text)
        {
            this.Speaker = speaker;
            this.Text = text;
        }

        /// <summary>
        /// Gets the name of the speaker.
        /// </summary>
        /// <value>
        /// The speaker.
        /// </value>
        public string Speaker { get; set; }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the callback.
        /// </summary>
        /// <value>
        /// The callback.
        /// </value>
        public Action<Ped> Callback { get; set; }
    }
}

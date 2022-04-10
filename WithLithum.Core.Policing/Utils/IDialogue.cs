using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;

namespace WithLithum.Core.Policing.Utils
{
    /// <summary>
    /// Represents a dialogue.
    /// </summary>
    public interface IDialogue
    {
        /// <summary>
        /// Gets the name of the speaker.
        /// </summary>
        /// <value>
        /// The speaker.
        /// </value>
        string Speaker { get; }
        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        string Text { get; }
        /// <summary>
        /// Gets or sets the callback.
        /// </summary>
        /// <value>
        /// The callback.
        /// </value>
        Action<Ped> Callback { get; set; }
    }
}

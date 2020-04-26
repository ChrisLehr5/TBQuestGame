using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Outsider : Npc, ISpeak
    {
        Random r = new Random();

        public List<string> Messages { get; set; }

        protected override string InformationText()
        {
            return $"{Name} - {Description}";
        }

        public Outsider()
        {

        }

        public Outsider(int id, string name, TraitType trait, string description, List<string> messages)
            : base(id, name, trait, description)
        {
            Messages = messages;
        }

        /// <summary>
        /// generate a message or use default
        /// </summary>
        /// <returns>message text</returns>
        public string Speak()
        {
            if (this.Messages != null)
            {
                return GetMessage();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// randomly select a message from the list of messages
        /// </summary>
        /// <returns>message text</returns>
        private string GetMessage()
        {
            int messageIndex = r.Next(0, Messages.Count());
            return Messages[messageIndex];
        }
    }
}

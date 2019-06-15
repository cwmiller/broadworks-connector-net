using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal delete all messages menu keys.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class DeleteAllMessagesMenuKeysReadEntry 
    {

        
        private string _confirmDeletion;

        [XmlElement(ElementName = "confirmDeletion", IsNullable = false, Namespace = "")]
        public string ConfirmDeletion {
            get => _confirmDeletion;
            set {
                ConfirmDeletionSpecified = true;
                _confirmDeletion = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmDeletionSpecified { get; set; }
        
        private string _cancelDeletion;

        [XmlElement(ElementName = "cancelDeletion", IsNullable = false, Namespace = "")]
        public string CancelDeletion {
            get => _cancelDeletion;
            set {
                CancelDeletionSpecified = true;
                _cancelDeletion = value;
            }
        }

        [XmlIgnore]
        public bool CancelDeletionSpecified { get; set; }
        
    }
}

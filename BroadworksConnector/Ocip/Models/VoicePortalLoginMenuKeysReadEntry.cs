using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal login menu keys.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class VoicePortalLoginMenuKeysReadEntry 
    {

        
        private string _accessUsingOtherMailboxId;

        [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = false, Namespace = "")]
        public string AccessUsingOtherMailboxId {
            get => _accessUsingOtherMailboxId;
            set {
                AccessUsingOtherMailboxIdSpecified = true;
                _accessUsingOtherMailboxId = value;
            }
        }

        [XmlIgnore]
        public bool AccessUsingOtherMailboxIdSpecified { get; set; }
        
    }
}

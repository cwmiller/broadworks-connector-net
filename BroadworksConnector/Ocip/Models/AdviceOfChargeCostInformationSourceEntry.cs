using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The advice of charge cost information source entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19847""}]")]
    public class AdviceOfChargeCostInformationSourceEntry
    {

        private string _peerIdentity;

        [XmlElement(ElementName = "peerIdentity", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19847")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PeerIdentity
        {
            get => _peerIdentity;
            set
            {
                PeerIdentitySpecified = true;
                _peerIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool PeerIdentitySpecified { get; set; }

        private int _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19847")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        protected bool PrioritySpecified { get; set; }

    }
}

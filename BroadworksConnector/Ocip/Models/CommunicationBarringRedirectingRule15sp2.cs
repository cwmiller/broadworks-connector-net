using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CommunicationBarringRedirectingRule15sp2
    {
        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        public string Criteria
        {
            get => _criteria;
            set
            {
                CriteriaSpecified = true;
                _criteria = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction15sp2 _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction15sp2 Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
    }
}

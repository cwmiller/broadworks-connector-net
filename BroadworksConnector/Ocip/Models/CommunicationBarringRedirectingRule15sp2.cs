using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Redirecting Rule
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommunicationBarringRedirectingRule15sp2 
    {

        
        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        public string Criteria {
            get => _criteria;
            set {
                CriteriaSpecified = true;
                _criteria = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction15sp2 _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction15sp2 Action {
            get => _action;
            set {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
        
    }
}

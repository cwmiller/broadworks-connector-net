using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan being forwarded/transferred permissions.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class OutgoingCallingPlanRedirectedPermissions 
    {

        
        private bool _outsideGroup;

        [XmlElement(ElementName = "outsideGroup", IsNullable = false, Namespace = "")]
        public bool OutsideGroup {
            get => _outsideGroup;
            set {
                OutsideGroupSpecified = true;
                _outsideGroup = value;
            }
        }

        [XmlIgnore]
        public bool OutsideGroupSpecified { get; set; }
        
    }
}

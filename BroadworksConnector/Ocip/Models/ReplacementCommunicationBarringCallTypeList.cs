using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring Call Types that replaces a previously
    /// configured list. By convention, an element of this type may be set
    /// nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementCommunicationBarringCallTypeList 
    {

        
        private List<string> _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        public List<string> CallType {
            get => _callType;
            set {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeSpecified { get; set; }
        
    }
}

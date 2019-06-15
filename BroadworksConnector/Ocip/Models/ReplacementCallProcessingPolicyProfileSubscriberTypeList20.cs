using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of CallProcessingPolicyProfileSubscriberType20. The list replaces a previously configured list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementCallProcessingPolicyProfileSubscriberTypeList20 
    {

        
        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> _subscriberType;

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> SubscriberType {
            get => _subscriberType;
            set {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        public bool SubscriberTypeSpecified { get; set; }
        
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCallProcessingPolicyProfileGetRequest20.
        /// <see cref="SystemCallProcessingPolicyProfileGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> _assignedSubscriberType;

        [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> AssignedSubscriberType {
            get => _assignedSubscriberType;
            set {
                AssignedSubscriberTypeSpecified = true;
                _assignedSubscriberType = value;
            }
        }

        [XmlIgnore]
        public bool AssignedSubscriberTypeSpecified { get; set; }
        
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call processing policy profile in system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by SystemCallProcessingPolicyProfileModifyRequest20.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingPolicyProfileModifyRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        public string NewName {
            get => _newName;
            set {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        public bool NewNameSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementCallProcessingPolicyProfileSubscriberTypeList _assignedSubscriberTypeList;

        [XmlElement(ElementName = "assignedSubscriberTypeList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementCallProcessingPolicyProfileSubscriberTypeList AssignedSubscriberTypeList {
            get => _assignedSubscriberTypeList;
            set {
                AssignedSubscriberTypeListSpecified = true;
                _assignedSubscriberTypeList = value;
            }
        }

        [XmlIgnore]
        public bool AssignedSubscriberTypeListSpecified { get; set; }
        
    }
}

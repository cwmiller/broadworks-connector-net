using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a call processing policy profile to system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by SystemCallProcessingPolicyProfileAddRequest20.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingPolicyProfileAddRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:22120""}]")]
    public class SystemCallProcessingPolicyProfileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22120")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22120")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> _assignedSubscriberType = new List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType>();

        [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22120")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> AssignedSubscriberType
        {
            get => _assignedSubscriberType;
            set
            {
                AssignedSubscriberTypeSpecified = true;
                _assignedSubscriberType = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedSubscriberTypeSpecified { get; set; }

    }
}

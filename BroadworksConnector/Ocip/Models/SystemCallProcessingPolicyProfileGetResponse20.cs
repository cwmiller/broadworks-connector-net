using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCallProcessingPolicyProfileGetRequest20.
    /// <see cref="SystemCallProcessingPolicyProfileGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:23015""}]")]
    public class SystemCallProcessingPolicyProfileGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23015")]
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

        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> _assignedSubscriberType = new List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20>();

        [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23015")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> AssignedSubscriberType
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

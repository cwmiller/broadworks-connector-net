using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCallProcessingPolicyProfileGetRequest21.
    /// <see cref="SystemCallProcessingPolicyProfileGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:3601""}]")]
    public class SystemCallProcessingPolicyProfileGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:3601")]
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
        public bool DescriptionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> _assignedSubscriberType = new List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21>();

        [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:3601")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> AssignedSubscriberType
        {
            get => _assignedSubscriberType;
            set
            {
                AssignedSubscriberTypeSpecified = true;
                _assignedSubscriberType = value;
            }
        }

        [XmlIgnore]
        public bool AssignedSubscriberTypeSpecified { get; set; }

    }
}

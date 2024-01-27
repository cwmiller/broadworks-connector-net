using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of user services that replaces existing user services assgined to the user.
    /// 
    /// If a service is already assigned to the user, the service quantitiy will be updated if included.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4286""}]")]
    public class ReplacementCombinedUserServiceAssignmentList
    {

        protected List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment> _serviceName = new List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4286")]
        public List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment> ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceNameSpecified { get; set; }

    }
}

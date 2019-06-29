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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3182""}]")]
    public class ReplacementCombinedUserServiceAssignmentList
    {

        private List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment> _serviceName = new List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3182")]
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

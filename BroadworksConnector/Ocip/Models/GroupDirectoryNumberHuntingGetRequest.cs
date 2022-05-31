using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the properties of the DNH service for a specified serviceUserId.
    /// It gets the agents of a call center or hunt group that are members
    /// of a directory number hunting group.  They are agents that are not already
    /// assigned to any other directory number hunting group.
    /// The response is either GroupDirectoryNumberHuntingGetResponse or ErrorResponse.
    /// 
    /// Replaced by: GroupDirectoryNumberHuntingGetRequest17sp1
    /// <see cref="GroupDirectoryNumberHuntingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupDirectoryNumberHuntingGetRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9373""}]")]
    public class GroupDirectoryNumberHuntingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupDirectoryNumberHuntingGetResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9373")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}

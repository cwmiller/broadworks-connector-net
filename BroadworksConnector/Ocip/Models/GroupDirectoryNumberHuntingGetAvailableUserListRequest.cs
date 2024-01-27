using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the agents of a call center or hunt group that are available
    /// to be assigned to a directory number hunting group.  They are agents that
    /// are not already assigned to any other directory number hunting group.
    /// The response is either a GroupDirectoryNumberHuntingGetAvailableUserListResponse or ErrorResponse.
    /// <see cref="GroupDirectoryNumberHuntingGetAvailableUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""98227cfa4fa3d2af84e4bff7d8508ae7:46""}]")]
    public class GroupDirectoryNumberHuntingGetAvailableUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupDirectoryNumberHuntingGetAvailableUserListResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"98227cfa4fa3d2af84e4bff7d8508ae7:46")]
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

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
    /// The response is either GroupDirectoryNumberHuntingGetAvailableUserListResponse or ErrorResponse.
    /// <see cref="GroupDirectoryNumberHuntingGetAvailableUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7c509136e6ce6be616e313c3b28a0449:47""}]")]
    public class GroupDirectoryNumberHuntingGetAvailableUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:47")]
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

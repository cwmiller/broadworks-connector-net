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
    /// The response is either GroupDirectoryNumberHuntingGetResponse17sp1 or ErrorResponse.
    /// <see cref="GroupDirectoryNumberHuntingGetResponse17sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""98227cfa4fa3d2af84e4bff7d8508ae7:83""}]")]
    public class GroupDirectoryNumberHuntingGetRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupDirectoryNumberHuntingGetResponse17sp1>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"98227cfa4fa3d2af84e4bff7d8508ae7:83")]
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

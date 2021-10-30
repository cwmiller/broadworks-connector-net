using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
    /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse or ErrorResponse.
    /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1
    /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:12504""}]")]
    public class UserBroadWorksAnywhereGetAvailablePortalListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserBroadWorksAnywhereGetAvailablePortalListResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12504")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of users that are unreachable from the primary application server.
    /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 or an ErrorResponse.
    /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10719""}]")]
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22>
    {

        protected int _userListSizeLimit;

        [XmlElement(ElementName = "userListSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10719")]
        [MinInclusive(1)]
        [MaxInclusive(10000)]
        public int UserListSizeLimit
        {
            get => _userListSizeLimit;
            set
            {
                UserListSizeLimitSpecified = true;
                _userListSizeLimit = value;
            }
        }

        [XmlIgnore]
        protected bool UserListSizeLimitSpecified { get; set; }

    }
}

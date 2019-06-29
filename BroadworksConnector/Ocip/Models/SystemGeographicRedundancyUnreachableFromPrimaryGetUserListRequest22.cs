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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9630""}]")]
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _userListSizeLimit;

        [XmlElement(ElementName = "userListSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9630")]
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

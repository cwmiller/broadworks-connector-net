using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of migrated users.
    /// If the optional parameter userListSizeLimit is set, then the list returned in the response will contain entries up to value of userListSizeLimit.
    /// The response is either SystemMigratedUsersGetListResponse22 or ErrorResponse.
    /// <see cref="SystemMigratedUsersGetListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12377""}]")]
    public class SystemMigratedUsersGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMigratedUsersGetListResponse22>
    {

        protected int _userListSizeLimit;

        [XmlElement(ElementName = "userListSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12377")]
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

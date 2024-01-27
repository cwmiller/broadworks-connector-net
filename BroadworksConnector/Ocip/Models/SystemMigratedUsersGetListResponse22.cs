using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMigratedUsersGetListRequest22.
    /// The optional totalNumberOfMigratedUsers is returned only when the userListSizeLimit is set in the request and
    /// if the total number of migrated users is greater than the value of userListSizeLimit.
    /// <see cref="SystemMigratedUsersGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12394""}]")]
    public class SystemMigratedUsersGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _userId = new List<string>();

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12394")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> UserId
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

        protected int _totalNumberOfMigratedUsers;

        [XmlElement(ElementName = "totalNumberOfMigratedUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12394")]
        public int TotalNumberOfMigratedUsers
        {
            get => _totalNumberOfMigratedUsers;
            set
            {
                TotalNumberOfMigratedUsersSpecified = true;
                _totalNumberOfMigratedUsers = value;
            }
        }

        [XmlIgnore]
        protected bool TotalNumberOfMigratedUsersSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22.
    /// The Unreachable From Primary User table column headings are: "User ID", "Lineport".
    /// The optional totalNumberOfUnreachableFromPrimaryUsers is returned only when the userListSizeLimit is set in the request and
    /// if the total number of unreachable from primary users is greater than the value of userListSizeLimit.
    /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10619""}]")]
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _unreachableFromPrimaryUserTable;

        [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10619")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable
        {
            get => _unreachableFromPrimaryUserTable;
            set
            {
                UnreachableFromPrimaryUserTableSpecified = true;
                _unreachableFromPrimaryUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool UnreachableFromPrimaryUserTableSpecified { get; set; }

        protected int _totalNumberOfUnreachableFromPrimaryUsers;

        [XmlElement(ElementName = "totalNumberOfUnreachableFromPrimaryUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10619")]
        public int TotalNumberOfUnreachableFromPrimaryUsers
        {
            get => _totalNumberOfUnreachableFromPrimaryUsers;
            set
            {
                TotalNumberOfUnreachableFromPrimaryUsersSpecified = true;
                _totalNumberOfUnreachableFromPrimaryUsers = value;
            }
        }

        [XmlIgnore]
        protected bool TotalNumberOfUnreachableFromPrimaryUsersSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMaliciousCallTraceGetUserListRequest. The column headings are "Service Provider Id",
    /// "Group Id", "User Id", "Last Name", "First Name", "Phone Number", "Trace Type", "Status",
    /// "Hiragana Last Name" and "Hiragana First Name".
    /// 
    /// Replaced By: SystemMaliciousCallTraceGetResponse
    /// <see cref="SystemMaliciousCallTraceGetUserListRequest"/>
    /// <see cref="SystemMaliciousCallTraceGetResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28107""}]")]
    public class SystemMaliciousCallTraceGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28107")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserTableSpecified { get; set; }

    }
}

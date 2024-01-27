using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCommunicationBarringUserControlGetRequest.
    /// Identifies the profiles available to the user and which one if any
    /// is active as well as the lockout status.
    /// Contains a table with column headings: "Name", "Code", "Activated" and "Primary".
    /// <see cref="UserCommunicationBarringUserControlGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6844af6fc359ada5d958622d62cbd13f:114""}]")]
    public class UserCommunicationBarringUserControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _lockoutStatus;

        [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:114")]
        public bool LockoutStatus
        {
            get => _lockoutStatus;
            set
            {
                LockoutStatusSpecified = true;
                _lockoutStatus = value;
            }
        }

        [XmlIgnore]
        protected bool LockoutStatusSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:114")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable
        {
            get => _profileTable;
            set
            {
                ProfileTableSpecified = true;
                _profileTable = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileTableSpecified { get; set; }

    }
}

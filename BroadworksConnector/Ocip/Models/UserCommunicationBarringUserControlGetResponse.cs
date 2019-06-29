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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4277c572e54919d6e29f4c0fa69aaad1:114""}]")]
    public class UserCommunicationBarringUserControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _lockoutStatus;

        [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:114")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:114")]
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

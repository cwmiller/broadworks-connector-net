using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPAuthenticationTrunkGroupLockoutGetRequest.
    /// The column headings for the lockoutTable are:
    /// "Organization Id", "Organization Type", "Group Id", "Trunk Group Name", "Lockout Started", "Lockout Expires", "Lockout Count". Lockout times are shown in the system GMT time. When a permanent lockout is shown, the "Lockout Expires" column is empty and the "Lockout Count" column contains the word Permanent.
    /// <see cref="SystemSIPAuthenticationTrunkGroupLockoutGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16953""}]")]
    public class SystemSIPAuthenticationTrunkGroupLockoutGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _lockoutTable;

        [XmlElement(ElementName = "lockoutTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16953")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LockoutTable
        {
            get => _lockoutTable;
            set
            {
                LockoutTableSpecified = true;
                _lockoutTable = value;
            }
        }

        [XmlIgnore]
        protected bool LockoutTableSpecified { get; set; }

    }
}

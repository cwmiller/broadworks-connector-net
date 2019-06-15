using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPAuthenticationEndpointLockoutGetRequest.
    /// The column headings for the lockoutTable are:
    /// "Organization Id", "Organization Type", "Group Id", "Line/Port", "User ID", "First Name", "Last Name", "Lockout Started", "Lockout Expires", "Lockout Count". Lockout times are shown in the system GMT time. When a permanent lockout is shown, the "Lockout Expires" column is empty and the "Lockout Count" column contains the word Permanent.
        /// <see cref="SystemSIPAuthenticationEndpointLockoutGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPAuthenticationEndpointLockoutGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _lockoutTable;

        [XmlElement(ElementName = "lockoutTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LockoutTable {
            get => _lockoutTable;
            set {
                LockoutTableSpecified = true;
                _lockoutTable = value;
            }
        }

        [XmlIgnore]
        public bool LockoutTableSpecified { get; set; }
        
    }
}

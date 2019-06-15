using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetUserListRequest.
    /// The column headings for the deviceUserTable are: "Line/Port", "Last Name",
    /// "First Name", "Phone Number", "Service Provider Id", "Group Id", "User Id",
    /// "User Type", "Endpoint Type", "Primary Line/Port", "Order", "Extension", "Department", "Email Address", "Private Identity".
    /// If the identity/device profile is an identity, the table will contain a row for each TEL-URI in the Phone Number column.
    /// If the identity/device profile is a real device, rows for the alternate numbers are not included.
    /// The User Type column contains one of the enumerated UserType values.
    /// The Endpoint Type column contains one of the enumerated EndpointType values.
    /// The Private Identity column is empty is AS mode.
    /// 
    /// Replaced by: SystemAccessDeviceGetUserListResponse21sp1 in AS data mode.
        /// <see cref="SystemAccessDeviceGetUserListRequest"/>
        /// <see cref="SystemAccessDeviceGetUserListResponse21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceUserTable;

        [XmlElement(ElementName = "deviceUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceUserTable {
            get => _deviceUserTable;
            set {
                DeviceUserTableSpecified = true;
                _deviceUserTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceUserTableSpecified { get; set; }
        
    }
}

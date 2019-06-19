using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetUserListRequest21sp1.
    /// The column headings for the deviceUserTable are: "Line/Port", "Last Name",
    /// "First Name", "Phone Number", "User Id", "User Type", "Endpoint Type", "Order", "Primary Line/Port", "Extension", "Department", "Email Address", "Private Identity".
    /// In IMS mode, the table will contain a row for each TEL-URI in the Phone Number column.
    /// In Standalone mode, rows for the alternate numbers are not included.
    /// The User Type column contains one of the enumerated UserType values.
    /// The Endpoint Type column contains one of the enumerated EndpointType21sp1 values.
    /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
    /// The Private Identity column is empty is AS mode.
    /// <see cref="GroupAccessDeviceGetUserListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:861""}]")]
    public class GroupAccessDeviceGetUserListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceUserTable;

        [XmlElement(ElementName = "deviceUserTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:861")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceUserTable
        {
            get => _deviceUserTable;
            set
            {
                DeviceUserTableSpecified = true;
                _deviceUserTable = value;
            }
        }

        [XmlIgnore]
        public bool DeviceUserTableSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetUserListRequest.
    /// The column headings for the deviceUserTable are: "Line/Port", "Last Name",
    /// "First Name", "Phone Number", "Group Id", "User Id",
    /// "User Type", "Endpoint Type", "Primary Line/Port", "Order", "Extension", "Department", "Email Address", "Private Identity".
    /// In IMS mode, the table will contain a row for each TEL-URI in the Phone Number column.
    /// In standalone mode, rows for the alternate numbers are not included.
    /// The User Type column contains one of the enumerated UserType values.
    /// The Endpoint Type column contains one of the enumerated EndpointType values.
    /// The Private Identity column is empty is AS mode.
    /// 
    /// Replaced by: ServiceProviderAccessDeviceGetUserListResponse21sp1 in AS data mode.
    /// <see cref="ServiceProviderAccessDeviceGetUserListRequest"/>
    /// <see cref="ServiceProviderAccessDeviceGetUserListResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5845""}]")]
    public class ServiceProviderAccessDeviceGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceUserTable;

        [XmlElement(ElementName = "deviceUserTable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5845")]
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
        protected bool DeviceUserTableSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPolycomPhoneServicesGetPrimaryEndpointListRequest.
    /// The column headings for the deviceUserTable are: "Device Level", "Device Name", "Line/Port".
    /// <see cref="UserPolycomPhoneServicesGetPrimaryEndpointListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ff29a940e42c5c9737f7438c4e6eea9d:116""}]")]
    public class UserPolycomPhoneServicesGetPrimaryEndpointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceUserTable;

        [XmlElement(ElementName = "deviceUserTable", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:116")]
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

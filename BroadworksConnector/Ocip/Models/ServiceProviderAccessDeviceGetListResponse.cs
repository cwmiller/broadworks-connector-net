using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetListRequest.
    /// Contains a table of devices configured in the service provider.
    /// The column headings are: "Device Name", "Device Type", "Available Ports",
    /// "Net Address", "MAC Address", "Status", and "Version".
    /// <see cref="ServiceProviderAccessDeviceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:572""}]")]
    public class ServiceProviderAccessDeviceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

        [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:572")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AccessDeviceTable
        {
            get => _accessDeviceTable;
            set
            {
                AccessDeviceTableSpecified = true;
                _accessDeviceTable = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceTableSpecified { get; set; }

    }
}

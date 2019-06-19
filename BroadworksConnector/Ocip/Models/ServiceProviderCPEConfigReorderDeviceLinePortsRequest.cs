using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Reorder the lines of a Service Provider device. You can not add or delete line ports, only
    /// re-ordering the list is allowed. The ordered list of line ports can be obtained
    /// with the ServiceProviderAccessDeviceGetRequest command.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="ServiceProviderAccessDeviceGetRequest"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2148""}]")]
    public class ServiceProviderCPEConfigReorderDeviceLinePortsRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2148")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2148")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }

        private List<string> _orderedLinePortList = new List<string>();

        [XmlElement(ElementName = "orderedLinePortList", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2148")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> OrderedLinePortList
        {
            get => _orderedLinePortList;
            set
            {
                OrderedLinePortListSpecified = true;
                _orderedLinePortList = value;
            }
        }

        [XmlIgnore]
        public bool OrderedLinePortListSpecified { get; set; }

    }
}

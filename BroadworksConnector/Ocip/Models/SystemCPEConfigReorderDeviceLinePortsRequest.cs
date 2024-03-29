using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Reorder the lines of a System device. You can not add or delete line ports, only
    /// re-ordering the list is allowed. The ordered list of line ports can be obtained
    /// with the SystemAccessDeviceGetRequest16 command.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SystemAccessDeviceGetRequest16"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7282""}]")]
    public class SystemCPEConfigReorderDeviceLinePortsRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7282")]
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
        protected bool DeviceNameSpecified { get; set; }

        protected List<string> _orderedLinePortList = new List<string>();

        [XmlElement(ElementName = "orderedLinePortList", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7282")]
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
        protected bool OrderedLinePortListSpecified { get; set; }

    }
}

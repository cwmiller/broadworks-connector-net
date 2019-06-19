using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetAvailableDetailListRequest14.
    /// <see cref="GroupAccessDeviceGetAvailableDetailListRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24293""}]")]
    public class GroupAccessDeviceGetAvailableDetailListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice> _availableAccessDevice = new List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice>();

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24293")]
        public List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice> AvailableAccessDevice
        {
            get => _availableAccessDevice;
            set
            {
                AvailableAccessDeviceSpecified = true;
                _availableAccessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AvailableAccessDeviceSpecified { get; set; }

    }
}

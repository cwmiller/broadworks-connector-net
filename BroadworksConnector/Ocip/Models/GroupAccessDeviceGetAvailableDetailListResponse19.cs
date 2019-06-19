using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetAvailableDetailListRequest19.
    /// <see cref="GroupAccessDeviceGetAvailableDetailListRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:575""}]")]
    public class GroupAccessDeviceGetAvailableDetailListResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> _availableAccessDevice = new List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice>();

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:575")]
        public List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> AvailableAccessDevice
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

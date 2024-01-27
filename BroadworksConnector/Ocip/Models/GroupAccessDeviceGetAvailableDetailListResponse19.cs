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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:768""}]")]
    public class GroupAccessDeviceGetAvailableDetailListResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> _availableAccessDevice = new List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice>();

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:768")]
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
        protected bool AvailableAccessDeviceSpecified { get; set; }

    }
}

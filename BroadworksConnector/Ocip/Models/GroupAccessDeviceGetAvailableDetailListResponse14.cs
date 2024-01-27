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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:3105""}]")]
    public class GroupAccessDeviceGetAvailableDetailListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice> _availableAccessDevice = new List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice>();

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:3105")]
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
        protected bool AvailableAccessDeviceSpecified { get; set; }

    }
}

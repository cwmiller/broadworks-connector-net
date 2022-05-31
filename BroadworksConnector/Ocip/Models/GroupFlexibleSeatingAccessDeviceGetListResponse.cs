using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupFlexibleSeatingAccessDeviceGetListRequest
    /// <see cref="GroupFlexibleSeatingAccessDeviceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:76""}]")]
    public class GroupFlexibleSeatingAccessDeviceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> _availableAccessDevice = new List<BroadWorksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice>();

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:76")]
        public List<BroadWorksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> AvailableAccessDevice
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

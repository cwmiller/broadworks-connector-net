using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupSessionAdmissionControlGetAvailableDeviceListRequest.
    /// Contains a table of devices can be assigned to session admission control group in the group.
    /// <see cref="GroupSessionAdmissionControlGetAvailableDeviceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6975""}]")]
    public class GroupSessionAdmissionControlGetAvailableDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.AccessDevice> _accessDevice = new List<BroadWorksConnector.Ocip.Models.AccessDevice>();

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6975")]
        public List<BroadWorksConnector.Ocip.Models.AccessDevice> AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }

    }
}

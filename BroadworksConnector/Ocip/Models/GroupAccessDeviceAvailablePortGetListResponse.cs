using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceAvailablePortGetListRequest.
    /// Contains a list of available ports in a device using static mode. The list is empty in case the device is using dynamic mode.
    /// <see cref="GroupAccessDeviceAvailablePortGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:360""}]")]
    public class GroupAccessDeviceAvailablePortGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<int> _portNumber = new List<int>();

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:360")]
        [MinInclusive(1)]
        [MaxInclusive(1024)]
        public List<int> PortNumber
        {
            get => _portNumber;
            set
            {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PortNumberSpecified { get; set; }

    }
}

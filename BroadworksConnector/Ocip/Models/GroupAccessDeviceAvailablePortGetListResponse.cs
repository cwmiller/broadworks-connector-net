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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:349""}]")]
    public class GroupAccessDeviceAvailablePortGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<int> _portNumber = new List<int>();

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:349")]
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

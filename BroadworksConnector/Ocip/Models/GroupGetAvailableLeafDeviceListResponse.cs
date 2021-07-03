using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGetAvailableLeafDeviceListRequest.
    /// <see cref="GroupGetAvailableLeafDeviceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5991""}]")]
    public class GroupGetAvailableLeafDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> _leafDeviceKey = new List<BroadWorksConnector.Ocip.Models.AccessDeviceKey>();

        [XmlElement(ElementName = "leafDeviceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5991")]
        public List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> LeafDeviceKey
        {
            get => _leafDeviceKey;
            set
            {
                LeafDeviceKeySpecified = true;
                _leafDeviceKey = value;
            }
        }

        [XmlIgnore]
        protected bool LeafDeviceKeySpecified { get; set; }

    }
}

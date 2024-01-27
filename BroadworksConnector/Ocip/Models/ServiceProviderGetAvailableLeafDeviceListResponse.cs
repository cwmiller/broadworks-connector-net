using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderGetAvailableLeafDeviceListRequest.
    /// Replaced by: ServiceProviderGetAvailableLeafDeviceListResponse22.
    /// <see cref="ServiceProviderGetAvailableLeafDeviceListRequest"/>
    /// <see cref="ServiceProviderGetAvailableLeafDeviceListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19338""}]")]
    public class ServiceProviderGetAvailableLeafDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> _leafDeviceKey = new List<BroadWorksConnector.Ocip.Models.AccessDeviceKey>();

        [XmlElement(ElementName = "leafDeviceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:19338")]
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

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderGetAvailableLeafDeviceListRequest22.
    /// <see cref="ServiceProviderGetAvailableLeafDeviceListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4448""}]")]
    public class ServiceProviderGetAvailableLeafDeviceListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> _leafDeviceKey = new List<BroadWorksConnector.Ocip.Models.AccessDeviceKey>();

        [XmlElement(ElementName = "leafDeviceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4448")]
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

        protected List<BroadWorksConnector.Ocip.Models.SupportLinks22V2> _supportLinks = new List<BroadWorksConnector.Ocip.Models.SupportLinks22V2>();

        [XmlElement(ElementName = "supportLinks", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4448")]
        public List<BroadWorksConnector.Ocip.Models.SupportLinks22V2> SupportLinks
        {
            get => _supportLinks;
            set
            {
                SupportLinksSpecified = true;
                _supportLinks = value;
            }
        }

        [XmlIgnore]
        protected bool SupportLinksSpecified { get; set; }

    }
}

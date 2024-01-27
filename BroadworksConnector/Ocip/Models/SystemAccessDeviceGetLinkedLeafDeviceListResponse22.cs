using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetLinkedLeafDeviceListRequest22.
    /// <see cref="SystemAccessDeviceGetLinkedLeafDeviceListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1184""}]")]
    public class SystemAccessDeviceGetLinkedLeafDeviceListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _treeDeviceLinkId;

        [XmlElement(ElementName = "treeDeviceLinkId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1184")]
        public string TreeDeviceLinkId
        {
            get => _treeDeviceLinkId;
            set
            {
                TreeDeviceLinkIdSpecified = true;
                _treeDeviceLinkId = value;
            }
        }

        [XmlIgnore]
        protected bool TreeDeviceLinkIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> _leafDeviceKey = new List<BroadWorksConnector.Ocip.Models.AccessDeviceKey>();

        [XmlElement(ElementName = "leafDeviceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:1184")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:1184")]
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

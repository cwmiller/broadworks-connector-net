using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetLinkedLeafDeviceListRequest.
    /// Replaced by: SystemAccessDeviceGetLinkedLeafDeviceListResponse22.
    /// <see cref="SystemAccessDeviceGetLinkedLeafDeviceListRequest"/>
    /// <see cref="SystemAccessDeviceGetLinkedLeafDeviceListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20216""}]")]
    public class SystemAccessDeviceGetLinkedLeafDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _treeDeviceLinkId;

        [XmlElement(ElementName = "treeDeviceLinkId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20216")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:20216")]
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

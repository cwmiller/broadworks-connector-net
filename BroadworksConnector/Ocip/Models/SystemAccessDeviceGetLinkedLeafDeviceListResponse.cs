using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetLinkedLeafDeviceListRequest.
    /// <see cref="SystemAccessDeviceGetLinkedLeafDeviceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1170""}]")]
    public class SystemAccessDeviceGetLinkedLeafDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _treeDeviceLinkId;

        [XmlElement(ElementName = "treeDeviceLinkId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1170")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1170")]
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

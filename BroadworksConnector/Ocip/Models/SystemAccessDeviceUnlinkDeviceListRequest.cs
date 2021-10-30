using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to unlink one or more leaf access devices from a tree device.
    /// A leaf device is a device associated with a device type that has the option
    /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1808""}]")]
    public class SystemAccessDeviceUnlinkDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> _leafDeviceKey = new List<BroadWorksConnector.Ocip.Models.AccessDeviceKey>();

        [XmlElement(ElementName = "leafDeviceKey", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1808")]
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

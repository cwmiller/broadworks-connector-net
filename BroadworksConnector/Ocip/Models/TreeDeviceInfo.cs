using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Information related to a tree device.
    /// A tree device is a device associated with a device type that has the option
    /// supportLinks set to "Support Links from Devices"..  Many leaf devices can link to it.
    /// When a tree device is created, it is assigned a system-wide unique linkId.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:5253""}]")]
    public class TreeDeviceInfo
    {

        protected BroadWorksConnector.Ocip.Models.AccessDeviceKey _treeDeviceKey;

        [XmlElement(ElementName = "treeDeviceKey", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5253")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceKey TreeDeviceKey
        {
            get => _treeDeviceKey;
            set
            {
                TreeDeviceKeySpecified = true;
                _treeDeviceKey = value;
            }
        }

        [XmlIgnore]
        protected bool TreeDeviceKeySpecified { get; set; }

        protected string _linkId;

        [XmlElement(ElementName = "linkId", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5253")]
        public string LinkId
        {
            get => _linkId;
            set
            {
                LinkIdSpecified = true;
                _linkId = value;
            }
        }

        [XmlIgnore]
        protected bool LinkIdSpecified { get; set; }

    }
}

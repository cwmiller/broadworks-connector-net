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
    /// supportLinks set to "Support Links from Devices".  Many leaf devices can link to it.
    /// When a tree device is created, it is assigned a system-wide unique linkId.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4788""}]")]
    public class TreeDeviceInfo
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceKey _treeDeviceKey;

        [XmlElement(ElementName = "treeDeviceKey", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4788")]
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

        private string _linkId;

        [XmlElement(ElementName = "linkId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4788")]
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

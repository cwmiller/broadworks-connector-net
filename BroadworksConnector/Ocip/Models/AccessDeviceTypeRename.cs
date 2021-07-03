using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Pair of DeviceManagementTagSetName
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:538""}]")]
    public class AccessDeviceTypeRename
    {

        private string _originalDeviceTypeName;

        [XmlElement(ElementName = "originalDeviceTypeName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:538")]
        [MinLength(1)]
        [MaxLength(40)]
        public string OriginalDeviceTypeName
        {
            get => _originalDeviceTypeName;
            set
            {
                OriginalDeviceTypeNameSpecified = true;
                _originalDeviceTypeName = value;
            }
        }

        [XmlIgnore]
        protected bool OriginalDeviceTypeNameSpecified { get; set; }

        private string _newDeviceTypeName;

        [XmlElement(ElementName = "newDeviceTypeName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:538")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewDeviceTypeName
        {
            get => _newDeviceTypeName;
            set
            {
                NewDeviceTypeNameSpecified = true;
                _newDeviceTypeName = value;
            }
        }

        [XmlIgnore]
        protected bool NewDeviceTypeNameSpecified { get; set; }

    }
}

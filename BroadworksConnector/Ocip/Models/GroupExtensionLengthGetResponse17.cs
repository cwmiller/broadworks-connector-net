using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExtensionLengthGetRequest17.
    /// <see cref="GroupExtensionLengthGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4855""}]")]
    public class GroupExtensionLengthGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4855")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MinExtensionLength
        {
            get => _minExtensionLength;
            set
            {
                MinExtensionLengthSpecified = true;
                _minExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool MinExtensionLengthSpecified { get; set; }

        private int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4855")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MaxExtensionLength
        {
            get => _maxExtensionLength;
            set
            {
                MaxExtensionLengthSpecified = true;
                _maxExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool MaxExtensionLengthSpecified { get; set; }

        private int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4855")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int DefaultExtensionLength
        {
            get => _defaultExtensionLength;
            set
            {
                DefaultExtensionLengthSpecified = true;
                _defaultExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool DefaultExtensionLengthSpecified { get; set; }

    }
}

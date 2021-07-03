using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExtensionLengthGetRequest17.
    /// 
    /// Replaced by: GroupExtensionLengthGetResponse22 in AS data mode
    /// <see cref="GroupExtensionLengthGetRequest17"/>
    /// <see cref="GroupExtensionLengthGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:2285""}]")]
    public class GroupExtensionLengthGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2285")]
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
        protected bool MinExtensionLengthSpecified { get; set; }

        private int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2285")]
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
        protected bool MaxExtensionLengthSpecified { get; set; }

        private int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2285")]
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
        protected bool DefaultExtensionLengthSpecified { get; set; }

    }
}

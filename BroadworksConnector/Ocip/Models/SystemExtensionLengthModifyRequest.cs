using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group's extension length range.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8982""}]")]
    public class SystemExtensionLengthModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8982")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8982")]
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

    }
}

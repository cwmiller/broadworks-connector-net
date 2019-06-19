using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExtensionLengthGetRequest.
    /// <see cref="GroupExtensionLengthGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:13615""}]")]
    public class GroupExtensionLengthGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13615")]
        [MinInclusive(2)]
        [MaxInclusive(6)]
        public int ExtensionLength
        {
            get => _extensionLength;
            set
            {
                ExtensionLengthSpecified = true;
                _extensionLength = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionLengthSpecified { get; set; }

    }
}

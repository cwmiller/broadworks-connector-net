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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9768""}]")]
    public class GroupExtensionLengthGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9768")]
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
        protected bool ExtensionLengthSpecified { get; set; }

    }
}

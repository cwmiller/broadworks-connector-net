using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemPasswordSecurityParametersGetResponse.
    /// The response contains the password security parameters for the system.
    /// <see cref="SystemPasswordSecurityParametersGetResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13072""}]")]
    public class SystemPasswordSecurityParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useExistingHashing;

        [XmlElement(ElementName = "useExistingHashing", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13072")]
        public bool UseExistingHashing
        {
            get => _useExistingHashing;
            set
            {
                UseExistingHashingSpecified = true;
                _useExistingHashing = value;
            }
        }

        [XmlIgnore]
        public bool UseExistingHashingSpecified { get; set; }

        private bool _enforcePasswordChangeOnExpiry;

        [XmlElement(ElementName = "enforcePasswordChangeOnExpiry", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13072")]
        public bool EnforcePasswordChangeOnExpiry
        {
            get => _enforcePasswordChangeOnExpiry;
            set
            {
                EnforcePasswordChangeOnExpirySpecified = true;
                _enforcePasswordChangeOnExpiry = value;
            }
        }

        [XmlIgnore]
        public bool EnforcePasswordChangeOnExpirySpecified { get; set; }

    }
}

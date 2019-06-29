using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the password security settings for the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13089""}]")]
    public class SystemPasswordSecurityParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _useExistingHashing;

        [XmlElement(ElementName = "useExistingHashing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13089")]
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
        protected bool UseExistingHashingSpecified { get; set; }

        private bool _enforcePasswordChangeOnExpiry;

        [XmlElement(ElementName = "enforcePasswordChangeOnExpiry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13089")]
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
        protected bool EnforcePasswordChangeOnExpirySpecified { get; set; }

    }
}

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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14424""}]")]
    public class SystemPasswordSecurityParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useExistingHashing;

        [XmlElement(ElementName = "useExistingHashing", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14424")]
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

        protected bool _enforcePasswordChangeOnExpiry;

        [XmlElement(ElementName = "enforcePasswordChangeOnExpiry", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14424")]
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

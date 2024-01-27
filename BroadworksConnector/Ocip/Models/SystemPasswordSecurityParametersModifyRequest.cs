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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14441""}]")]
    public class SystemPasswordSecurityParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _useExistingHashing;

        [XmlElement(ElementName = "useExistingHashing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14441")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14441")]
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

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Caller Id Disposition mapping.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18368""}]")]
    public class SystemStirShakenCallerIdDispositionMappingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.CallerIdDispositionVerstat _verstat;

        [XmlElement(ElementName = "verstat", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18368")]
        public BroadWorksConnector.Ocip.Models.CallerIdDispositionVerstat Verstat
        {
            get => _verstat;
            set
            {
                VerstatSpecified = true;
                _verstat = value;
            }
        }

        [XmlIgnore]
        protected bool VerstatSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel? _attestationLevel;

        [XmlElement(ElementName = "attestationLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18368")]
        public BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel? AttestationLevel
        {
            get => _attestationLevel;
            set
            {
                AttestationLevelSpecified = (value != null);
                _attestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AttestationLevelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallerIdDisposition? _disposition;

        [XmlElement(ElementName = "disposition", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18368")]
        public BroadWorksConnector.Ocip.Models.CallerIdDisposition? Disposition
        {
            get => _disposition;
            set
            {
                DispositionSpecified = (value != null);
                _disposition = value;
            }
        }

        [XmlIgnore]
        protected bool DispositionSpecified { get; set; }

    }
}

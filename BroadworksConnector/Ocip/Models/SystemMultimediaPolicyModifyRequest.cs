using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Multimedia Policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The Following element is only used in AS data mode:
    /// -  alwaysAllowTelephoneEvents
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12555""}]")]
    public class SystemMultimediaPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _restrictNonAudioVideoMediaTypes;

        [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12555")]
        public bool? RestrictNonAudioVideoMediaTypes
        {
            get => _restrictNonAudioVideoMediaTypes;
            set
            {
                RestrictNonAudioVideoMediaTypesSpecified = (value != null);
                _restrictNonAudioVideoMediaTypes = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictNonAudioVideoMediaTypesSpecified { get; set; }

        protected bool? _alwaysAllowTelephoneEvents;

        [XmlElement(ElementName = "alwaysAllowTelephoneEvents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12555")]
        public bool? AlwaysAllowTelephoneEvents
        {
            get => _alwaysAllowTelephoneEvents;
            set
            {
                AlwaysAllowTelephoneEventsSpecified = (value != null);
                _alwaysAllowTelephoneEvents = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysAllowTelephoneEventsSpecified { get; set; }

    }
}

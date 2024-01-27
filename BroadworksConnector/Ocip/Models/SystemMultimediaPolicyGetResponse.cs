using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMultimediaPolicyGetRequest
    /// <see cref="SystemMultimediaPolicyGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12425""}]")]
    public class SystemMultimediaPolicyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _restrictNonAudioVideoMediaTypes;

        [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12425")]
        public bool RestrictNonAudioVideoMediaTypes
        {
            get => _restrictNonAudioVideoMediaTypes;
            set
            {
                RestrictNonAudioVideoMediaTypesSpecified = true;
                _restrictNonAudioVideoMediaTypes = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictNonAudioVideoMediaTypesSpecified { get; set; }

    }
}

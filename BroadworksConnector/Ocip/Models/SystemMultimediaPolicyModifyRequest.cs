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
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12319""}]")]
    public class SystemMultimediaPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private bool _restrictNonAudioVideoMediaTypes;

        [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12319")]
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

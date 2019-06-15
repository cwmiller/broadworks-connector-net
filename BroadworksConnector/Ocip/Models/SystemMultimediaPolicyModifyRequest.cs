using System;
using System.Xml.Serialization;
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
     
    public class SystemMultimediaPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _restrictNonAudioVideoMediaTypes;

        [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false, Namespace = "")]
        public bool RestrictNonAudioVideoMediaTypes {
            get => _restrictNonAudioVideoMediaTypes;
            set {
                RestrictNonAudioVideoMediaTypesSpecified = true;
                _restrictNonAudioVideoMediaTypes = value;
            }
        }

        [XmlIgnore]
        public bool RestrictNonAudioVideoMediaTypesSpecified { get; set; }
        
    }
}

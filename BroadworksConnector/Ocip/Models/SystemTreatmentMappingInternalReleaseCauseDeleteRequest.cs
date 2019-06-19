using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an Internal Release Cause mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17725""}]")]
    public class SystemTreatmentMappingInternalReleaseCauseDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

        [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17725")]
        public BroadWorksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause
        {
            get => _internalReleaseCause;
            set
            {
                InternalReleaseCauseSpecified = true;
                _internalReleaseCause = value;
            }
        }

        [XmlIgnore]
        public bool InternalReleaseCauseSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a Media from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10619""}]")]
    public class SystemMediaDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _mediaName;

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10619")]
        [MinLength(1)]
        [MaxLength(80)]
        public string MediaName
        {
            get => _mediaName;
            set
            {
                MediaNameSpecified = true;
                _mediaName = value;
            }
        }

        [XmlIgnore]
        public bool MediaNameSpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Security Classification
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""435c279b3e6710f4ada60ed66a93d278:275""}]")]
    public class SystemSecurityClassificationModifyClassificationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _securityClassificationName;

        [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:275")]
        [MinLength(1)]
        [MaxLength(40)]
        public string SecurityClassificationName
        {
            get => _securityClassificationName;
            set
            {
                SecurityClassificationNameSpecified = true;
                _securityClassificationName = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityClassificationNameSpecified { get; set; }

        protected string _newSecurityClassificationName;

        [XmlElement(ElementName = "newSecurityClassificationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:275")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewSecurityClassificationName
        {
            get => _newSecurityClassificationName;
            set
            {
                NewSecurityClassificationNameSpecified = true;
                _newSecurityClassificationName = value;
            }
        }

        [XmlIgnore]
        protected bool NewSecurityClassificationNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:275")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileSpecified { get; set; }

    }
}

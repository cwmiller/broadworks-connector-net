using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's digit collection attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8194""}]")]
    public class SystemDigitCollectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8194")]
        [MinLength(1)]
        [MaxLength(1)]
        public string AccessCode
        {
            get => _accessCode;
            set
            {
                AccessCodeSpecified = true;
                _accessCode = value;
            }
        }

        [XmlIgnore]
        public bool AccessCodeSpecified { get; set; }

        private string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8194")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PublicDigitMap
        {
            get => _publicDigitMap;
            set
            {
                PublicDigitMapSpecified = true;
                _publicDigitMap = value;
            }
        }

        [XmlIgnore]
        public bool PublicDigitMapSpecified { get; set; }

        private string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8194")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PrivateDigitMap
        {
            get => _privateDigitMap;
            set
            {
                PrivateDigitMapSpecified = true;
                _privateDigitMap = value;
            }
        }

        [XmlIgnore]
        public bool PrivateDigitMapSpecified { get; set; }

    }
}

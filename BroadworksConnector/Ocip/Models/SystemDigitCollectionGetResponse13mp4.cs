using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDigitCollectionGetRequest13mp4.
    /// <see cref="SystemDigitCollectionGetRequest13mp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9369""}]")]
    public class SystemDigitCollectionGetResponse13mp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9369")]
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
        protected bool AccessCodeSpecified { get; set; }

        protected string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9369")]
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
        protected bool PublicDigitMapSpecified { get; set; }

        protected string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9369")]
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
        protected bool PrivateDigitMapSpecified { get; set; }

    }
}

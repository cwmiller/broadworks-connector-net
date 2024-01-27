using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Media Set.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12275""}]")]
    public class SystemMediaSetModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12275")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SetName
        {
            get => _setName;
            set
            {
                SetNameSpecified = true;
                _setName = value;
            }
        }

        [XmlIgnore]
        protected bool SetNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementMediaNameList _mediaNameList;

        [XmlElement(ElementName = "mediaNameList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12275")]
        public BroadWorksConnector.Ocip.Models.ReplacementMediaNameList MediaNameList
        {
            get => _mediaNameList;
            set
            {
                MediaNameListSpecified = true;
                _mediaNameList = value;
            }
        }

        [XmlIgnore]
        protected bool MediaNameListSpecified { get; set; }

    }
}

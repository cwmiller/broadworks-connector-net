using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Xsi application system parameter.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19739""}]")]
    public class SystemXsiApplicationIdParameterModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _screenXsiApplicationId;

        [XmlElement(ElementName = "screenXsiApplicationId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19739")]
        public bool ScreenXsiApplicationId
        {
            get => _screenXsiApplicationId;
            set
            {
                ScreenXsiApplicationIdSpecified = true;
                _screenXsiApplicationId = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenXsiApplicationIdSpecified { get; set; }

    }
}

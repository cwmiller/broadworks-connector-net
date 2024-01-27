using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemXsiApplictionIdParameterGetRequest.
    /// Contains the Xsi application id system parameters.
    /// <see cref="SystemXsiApplictionIdParameterGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19723""}]")]
    public class SystemXsiApplicationIdParameterGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _screenXsiApplicationId;

        [XmlElement(ElementName = "screenXsiApplicationId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19723")]
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

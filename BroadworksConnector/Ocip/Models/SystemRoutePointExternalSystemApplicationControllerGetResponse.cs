using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoutePointExternalSystemApplicationControllerGetRequest.
    /// <see cref="SystemRoutePointExternalSystemApplicationControllerGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15307""}]")]
    public class SystemRoutePointExternalSystemApplicationControllerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _applicationController = new List<string>();

        [XmlElement(ElementName = "applicationController", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15307")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> ApplicationController
        {
            get => _applicationController;
            set
            {
                ApplicationControllerSpecified = true;
                _applicationController = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationControllerSpecified { get; set; }

    }
}

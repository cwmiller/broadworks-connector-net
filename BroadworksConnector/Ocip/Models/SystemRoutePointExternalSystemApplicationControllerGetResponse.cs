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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13995""}]")]
    public class SystemRoutePointExternalSystemApplicationControllerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _applicationController = new List<string>();

        [XmlElement(ElementName = "applicationController", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13995")]
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
        public bool ApplicationControllerSpecified { get; set; }

    }
}

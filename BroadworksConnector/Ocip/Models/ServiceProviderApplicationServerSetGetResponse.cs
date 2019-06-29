using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderApplicationServerSetGetRequest.
    /// The response contains the service provider or enterprise's Application Server set information.
    /// <see cref="ServiceProviderApplicationServerSetGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1268""}]")]
    public class ServiceProviderApplicationServerSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1268")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationServerSetName
        {
            get => _applicationServerSetName;
            set
            {
                ApplicationServerSetNameSpecified = true;
                _applicationServerSetName = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationServerSetNameSpecified { get; set; }

    }
}

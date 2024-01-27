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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1815""}]")]
    public class ServiceProviderApplicationServerSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1815")]
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

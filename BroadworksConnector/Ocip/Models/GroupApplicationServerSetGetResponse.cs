using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupApplicationServerSetGetRequest.
    /// The response contains the group's Application Server set information.
    /// <see cref="GroupApplicationServerSetGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:2157""}]")]
    public class GroupApplicationServerSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2157")]
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

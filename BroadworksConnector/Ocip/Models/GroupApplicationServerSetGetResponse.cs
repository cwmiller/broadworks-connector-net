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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:2224""}]")]
    public class GroupApplicationServerSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2224")]
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

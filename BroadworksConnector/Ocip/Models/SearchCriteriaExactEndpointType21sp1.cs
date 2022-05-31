using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular endpoint type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1014""}]")]
    public class SearchCriteriaExactEndpointType21sp1 : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.EndpointType21sp1 _endpointType;

        [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1014")]
        public BroadWorksConnector.Ocip.Models.EndpointType21sp1 EndpointType
        {
            get => _endpointType;
            set
            {
                EndpointTypeSpecified = true;
                _endpointType = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTypeSpecified { get; set; }

    }
}

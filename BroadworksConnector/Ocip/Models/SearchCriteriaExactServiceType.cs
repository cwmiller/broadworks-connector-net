using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified service type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1135""}]")]
    public class SearchCriteriaExactServiceType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.ServiceType _serviceType;

        [XmlElement(ElementName = "serviceType", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1135")]
        public BroadWorksConnector.Ocip.Models.ServiceType ServiceType
        {
            get => _serviceType;
            set
            {
                ServiceTypeSpecified = true;
                _serviceType = value;
            }
        }

        [XmlIgnore]
        public bool ServiceTypeSpecified { get; set; }

    }
}

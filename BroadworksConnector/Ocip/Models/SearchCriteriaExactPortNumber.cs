using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a port number.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1060""}]")]
    public class SearchCriteriaExactPortNumber : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1060")]
        [MinInclusive(1)]
        [MaxInclusive(1024)]
        public int Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }

    }
}

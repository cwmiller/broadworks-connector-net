using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of system service access codes.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeGetListResponse21 or ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1317""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeGetListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobilityServiceAccessCodeGetListResponse21>
    {

        protected string _serviceAccessCodeListName;

        [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1317")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceAccessCodeListName
        {
            get => _serviceAccessCodeListName;
            set
            {
                ServiceAccessCodeListNameSpecified = true;
                _serviceAccessCodeListName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAccessCodeListNameSpecified { get; set; }

    }
}

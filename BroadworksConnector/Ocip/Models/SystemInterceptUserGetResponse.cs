using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemInterceptUserGetRequest.
    /// <see cref="SystemInterceptUserGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:219""}]")]
    public class SystemInterceptUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _emergencyAndRepairIntercept;

        [XmlElement(ElementName = "emergencyAndRepairIntercept", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:219")]
        public bool EmergencyAndRepairIntercept
        {
            get => _emergencyAndRepairIntercept;
            set
            {
                EmergencyAndRepairInterceptSpecified = true;
                _emergencyAndRepairIntercept = value;
            }
        }

        [XmlIgnore]
        public bool EmergencyAndRepairInterceptSpecified { get; set; }

    }
}

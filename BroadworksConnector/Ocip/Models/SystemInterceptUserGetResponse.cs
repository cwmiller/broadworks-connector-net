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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2a762bb9361e88044885b796c1d6b979:219""}]")]
    public class SystemInterceptUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _emergencyAndRepairIntercept;

        [XmlElement(ElementName = "emergencyAndRepairIntercept", IsNullable = false, Namespace = "")]
        [Group(@"2a762bb9361e88044885b796c1d6b979:219")]
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
        protected bool EmergencyAndRepairInterceptSpecified { get; set; }

    }
}

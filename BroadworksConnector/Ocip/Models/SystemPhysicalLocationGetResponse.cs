using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPhysicalLocationGetRequest.
    /// Contains a list of system Physical Location parameters.
    /// <see cref="SystemPhysicalLocationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8250786d50d10f8fe081d126ecca3847:57""}]")]
    public class SystemPhysicalLocationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _alwaysAllowEmergencyCalls;

        [XmlElement(ElementName = "alwaysAllowEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"8250786d50d10f8fe081d126ecca3847:57")]
        public bool AlwaysAllowEmergencyCalls
        {
            get => _alwaysAllowEmergencyCalls;
            set
            {
                AlwaysAllowEmergencyCallsSpecified = true;
                _alwaysAllowEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysAllowEmergencyCallsSpecified { get; set; }

    }
}

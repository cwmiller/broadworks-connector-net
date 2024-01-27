using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCustomerOriginatedTraceGetRequest.
    /// <see cref="SystemCustomerOriginatedTraceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b879060a029bc884d4ec2c341a2783f:57""}]")]
    public class SystemCustomerOriginatedTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _screenMaliciousCallers;

        [XmlElement(ElementName = "screenMaliciousCallers", IsNullable = false, Namespace = "")]
        [Group(@"4b879060a029bc884d4ec2c341a2783f:57")]
        public bool ScreenMaliciousCallers
        {
            get => _screenMaliciousCallers;
            set
            {
                ScreenMaliciousCallersSpecified = true;
                _screenMaliciousCallers = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenMaliciousCallersSpecified { get; set; }

    }
}

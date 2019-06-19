using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest.
    /// The response contains of the list of system level successful SIP OPTIONS message respoonse status codes.
    /// <see cref="SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1777""}]")]
    public class SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _statusCode = new List<string>();

        [XmlElement(ElementName = "statusCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1777")]
        [MinLength(3)]
        [MaxLength(40)]
        public List<string> StatusCode
        {
            get => _statusCode;
            set
            {
                StatusCodeSpecified = true;
                _statusCode = value;
            }
        }

        [XmlIgnore]
        public bool StatusCodeSpecified { get; set; }

    }
}

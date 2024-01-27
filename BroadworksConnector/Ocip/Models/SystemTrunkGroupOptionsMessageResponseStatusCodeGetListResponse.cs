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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1855""}]")]
    public class SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _statusCode = new List<string>();

        [XmlElement(ElementName = "statusCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1855")]
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
        protected bool StatusCodeSpecified { get; set; }

    }
}

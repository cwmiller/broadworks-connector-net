using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a performance measurements reporting ftp server.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13285""}]")]
    public class SystemPerformanceMeasurementReportingModifyFileServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _ftpHostNetAddress;

        [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13285")]
        [MinLength(1)]
        [MaxLength(80)]
        public string FtpHostNetAddress
        {
            get => _ftpHostNetAddress;
            set
            {
                FtpHostNetAddressSpecified = true;
                _ftpHostNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool FtpHostNetAddressSpecified { get; set; }

        private bool _passiveFTP;

        [XmlElement(ElementName = "passiveFTP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13285")]
        public bool PassiveFTP
        {
            get => _passiveFTP;
            set
            {
                PassiveFTPSpecified = true;
                _passiveFTP = value;
            }
        }

        [XmlIgnore]
        protected bool PassiveFTPSpecified { get; set; }

    }
}

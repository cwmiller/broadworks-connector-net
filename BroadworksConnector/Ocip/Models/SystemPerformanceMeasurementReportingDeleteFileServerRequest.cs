using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a performance measurements reporting ftp server.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28797""}]")]
    public class SystemPerformanceMeasurementReportingDeleteFileServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _ftpHostNetAddress;

        [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28797")]
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

    }
}

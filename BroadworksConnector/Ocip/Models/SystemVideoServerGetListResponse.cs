using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVideoServerGetListRequest. The Video Server table column
    /// headings are: "Net Address", "Port", "Transport", "Description".
    /// Transport types: udp, tcp, unspecified
    /// <see cref="SystemVideoServerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19192""}]")]
    public class SystemVideoServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _videoServerTable;

        [XmlElement(ElementName = "videoServerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19192")]
        public BroadWorksConnector.Ocip.Models.C.OCITable VideoServerTable
        {
            get => _videoServerTable;
            set
            {
                VideoServerTableSpecified = true;
                _videoServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool VideoServerTableSpecified { get; set; }

    }
}

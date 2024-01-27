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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19428""}]")]
    public class SystemVideoServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _videoServerTable;

        [XmlElement(ElementName = "videoServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19428")]
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

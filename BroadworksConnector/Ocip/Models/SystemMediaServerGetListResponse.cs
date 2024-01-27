using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaServerGetListRequest. The Media Server table column
    /// headings are: "Net Address", "Port", "Transport", "Description".
    /// <see cref="SystemMediaServerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12096""}]")]
    public class SystemMediaServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mediaServerTable;

        [XmlElement(ElementName = "mediaServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12096")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MediaServerTable
        {
            get => _mediaServerTable;
            set
            {
                MediaServerTableSpecified = true;
                _mediaServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool MediaServerTableSpecified { get; set; }

    }
}
